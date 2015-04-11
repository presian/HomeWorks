namespace NewsConsoleClient.Classes
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    [JsonObject]
    public class NewsLsit
    {
        [JsonProperty(PropertyName = "articles")]
        public IList<News> Articles { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "syndication_url")]
        public string SyndicationUrl { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}
