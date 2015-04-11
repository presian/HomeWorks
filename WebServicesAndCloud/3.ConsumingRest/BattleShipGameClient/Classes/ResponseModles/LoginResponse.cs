namespace BattleShipGameClient.Classes.ResponseModles
{
    using Newtonsoft.Json;

    [JsonObject]
    class LoginResponse
    {
        [JsonProperty(PropertyName = "access_token")]
        public string Token { get; set; }
    }
}
