namespace NewsConsoleClient.Classes
{
    using Newtonsoft.Json;

    [JsonObject]
    public class Category
    {
        [JsonProperty(PropertyName = "category_id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "display_category_name")]
        public string  DisplayName { get; set; }

        [JsonProperty(PropertyName = "english_category_name")]
        public string  EnglishName { get; set; }

        [JsonProperty(PropertyName = "url_category_name")]
        public string  UrlCategoryName { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} Name: {1}", this.Id, this.DisplayName);
        }
    }
}
