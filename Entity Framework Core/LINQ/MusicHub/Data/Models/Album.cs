﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        [Required] [MaxLength(40)] 
        public string Name { get; set; } = null!;

        [Required]
        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }


        [ForeignKey(nameof(ProducerId))]
        public Producer? Producer { get; set; }
        public int? ProducerId { get; set; }

        public ICollection<Song> Songs { get; set; }



        
    }
}
