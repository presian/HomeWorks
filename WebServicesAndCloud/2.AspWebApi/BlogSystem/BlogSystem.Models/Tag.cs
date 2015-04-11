using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BlogSystem.Models
{
    using System.Collections.Generic;

    [JsonObject]
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
