namespace MusicSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    public class Artist
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        [JsonIgnore]
        public virtual Country Country { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
