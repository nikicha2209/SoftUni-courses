using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MusicHub
{
    using System;

    using Data;
    using Initializer;

    public class StartUp
    {
        //Problem 1: Create the files in Data/Models
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);
            //Console.WriteLine(ExportAlbumsInfo(context, 4));
            Console.WriteLine(ExportSongsAboveDuration(context, 4));

            //Test your solutions here
        }


        //Problem 2: 
        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albumsInfo = context.Albums
                .Where(a => a.Producer.Id == producerId)
                .OrderByDescending(a => a.Price)
                .ToArray()
                .Select(a => new
                {
                    Name = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = a.Producer.Name,
                    Songs = a.Songs.Select(s => new
                    {
                        Name = s.Name,
                        Price = s.Price.ToString("f2"),
                        WriterName = s.Writer.Name
                    })
                        .OrderByDescending(s => s.Name)
                        .ThenBy(s => s.WriterName)
                        .ToArray(),

                    AlbumPrice = a.Price.ToString("f2")
                })
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var albumInfo in albumsInfo)
            {
                sb.AppendLine($"-AlbumName: {albumInfo.Name}");
                sb.AppendLine($"-ReleaseDate: {albumInfo.ReleaseDate}");
                sb.AppendLine($"-ProducerName: {albumInfo.ProducerName}");
                sb.AppendLine("-Songs:");
                int count = 1;

                foreach (var song in albumInfo.Songs.ToArray())
                {
                    sb.AppendLine($"---#{count}");
                    sb.AppendLine($"---SongName: {song.Name}");
                    sb.AppendLine($"---Price: {song.Price}");
                    sb.AppendLine($"---Writer: {song.WriterName}");
                    count++;
                }

                sb.AppendLine($"-AlbumPrice: {albumInfo.AlbumPrice}");

            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songs = context.Songs
                .AsEnumerable()
                .Where(s => s.Duration.TotalSeconds > duration)
                .ToArray()
                .Select(s => new
                {
                    Name = s.Name,
                    Performers = s.SongPerformers.Select(sp => new
                        {
                            FullName = sp.Performer.FirstName + " " + sp.Performer.LastName
                        })
                        .OrderBy(p => p.FullName)
                        .ToArray(),
                    WriterName = s.Writer.Name,
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration.ToString("c")
                })
                .OrderBy(s => s.Name)
                .ThenBy(s => s.WriterName)
                .ToArray();

            int songCount = 1;
            StringBuilder sb = new StringBuilder();
            foreach (var song in songs)
            {
                sb.AppendLine($"-Song #{songCount}");
                sb.AppendLine($"---SongName: {song.Name}");
                sb.AppendLine($"---Writer: {song.WriterName}");
                foreach (var performer in song.Performers)
                {
                    sb.AppendLine($"---Performer: {performer.FullName}");
                }

                sb.AppendLine($"---AlbumProducer: {song.AlbumProducer}");
                sb.AppendLine($"---Duration: {song.Duration}");
                songCount++;
            }

            return sb.ToString().TrimEnd();
        }
    }
}
