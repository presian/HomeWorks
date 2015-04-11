namespace BlogSystem.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Newtonsoft.Json;

    [ComplexType]
    [JsonObject]
    public class UserContactInfo
    {
        public string Facebook { get; set; }

        public string Skype { get; set; }

        public string Tweeter { get; set; }

        public string PhoneNumber { get; set; }
    }
}
