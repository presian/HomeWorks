namespace BlogSystem.Models
{
    using Newtonsoft.Json;

    [JsonObject]
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
