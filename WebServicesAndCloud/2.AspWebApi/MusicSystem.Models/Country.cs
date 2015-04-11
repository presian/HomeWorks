﻿namespace MusicSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}