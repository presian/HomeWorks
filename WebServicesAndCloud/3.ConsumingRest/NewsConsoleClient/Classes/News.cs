namespace NewsConsoleClient.Classes
{
    using Newtonsoft.Json;

    [JsonObject]
    public class News
    {
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "publish_date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty(PropertyName = "summary")]
        public string Summery { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        public override string ToString()
        {
            return string.Format("Title: {0}\nUrl: {1}", this.Title, this.Url);
        }
    }
}