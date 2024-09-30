using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CinemaApp.Common.EntityValidationConstants.Movie;

namespace CinemaApp.Data.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);

            builder.
                Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder
                .Property(m => m.Genre)
                .IsRequired()
                .HasMaxLength(GenreMaxLength);

            builder
                .Property(m => m.Director)
                .IsRequired()
                .HasMaxLength(DirectorNameMaxLength);

            builder
                .Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLength);

            builder.HasData(SeedMovies());
        }


        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie()
                {
                    Title="Inside Out 2",
                    Genre="Comedy",
                    ReleaseDate = new DateTime(2024,06,14),
                    Director="Kelsey Mann",
                    Duration=96,
                    Description="Inside Out 2 is a 2024 American animated coming-of-age film produced by Pixar Animation Studios for Walt Disney Pictures. The sequel to Inside Out (2015), it was directed by Kelsey Mann (in his feature directorial debut) and produced by Mark Nielsen, from a screenplay written by Meg LeFauve and Dave Holstein, and a story conceived by Mann and LeFauve."
                },

                new Movie()
                {
                    Title="Demon Slayer: Kimetsu no Yaiba – To the Hashira Training",
                    Genre="Fantasy",
                    ReleaseDate=new DateTime(2024, 02, 02),
                    Director="Haruo Sotozaki",
                    Duration=104,
                    Description="Demon Slayer: Kimetsu no Yaiba – To the Hashira Training is a 2024 Japanese animated dark fantasy action film based on the \"Swordsmith Village\" and \"Hashira Training\" arcs of the 2016–20 manga series Demon Slayer: Kimetsu no Yaiba by Koyoharu Gotouge. It is a direct sequel to the third season of the anime television series as well as its third film adaptation, following Demon Slayer: Kimetsu no Yaiba – The Movie: Mugen Train (2020) and Demon Slayer: Kimetsu no Yaiba – To the Swordsmith Village (2023)."
                }
            };

            return movies;
        }
    }
}
