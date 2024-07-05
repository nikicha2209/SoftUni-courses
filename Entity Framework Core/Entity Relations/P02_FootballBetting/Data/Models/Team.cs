using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        public string Name { get; set; }
        public string LogoUrl { get; set; }

        [StringLength(3)]
        public string Initials { get; set; }

        [Required]
        public decimal Budget { get; set; }


        [ForeignKey(nameof(PrimaryKitColorId))]
        public Color PrimaryKitColor { get; set; }
        public int PrimaryKitColorId { get; set; }


        [ForeignKey(nameof(SecondaryKitColorId))]
        public Color SecondaryKitColor { get; set; }
        public int SecondaryKitColorId { get; set; }


        [ForeignKey(nameof(TownId))]
        public Town Town { get; set; }
        public int TownId { get; set; }


        public ICollection<Player> Players { get; set; }


        [InverseProperty(nameof(Game.HomeTeam))]
        public ICollection<Game> HomeGames { get; set; }


        [InverseProperty(nameof(Game.AwayTeam))]
        public ICollection<Game> AwayGames { get; set; }

    }
}
