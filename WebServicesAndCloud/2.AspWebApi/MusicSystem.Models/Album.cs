namespace MusicSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    public class Album
    {
        public Album()
        {
            this.Artists = new HashSet<Artist>();
            this.Songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public int ProducerId { get; set; }

        [JsonIgnore]
        public virtual Producer Producer { get; set; }

        [JsonIgnore]
        public virtual HashSet<Artist> Artists { get; set; }

        [JsonIgnore]
        public virtual HashSet<Song> Songs { get; set; }
    }
}
