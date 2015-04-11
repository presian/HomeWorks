namespace MusicSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    
    using Newtonsoft.Json;
    
    public class Song
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public virtual Genre Genre { get; set; }

        public int ArtistId { get; set; }

        [JsonIgnore]
        public virtual Artist Artist { get; set; }

        public int AlbumId { get; set; }

        [JsonIgnore]
        public virtual Album Album { get; set; }
    }
}
