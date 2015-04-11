namespace BattleShipGameClient.Classes
{
    using System;
    using System.Net;

    using Newtonsoft.Json;
    using RestSharp;
    
    public class Requester
    {
        private readonly RestClient client;
        private string token;

        public Requester()
        {
            this.client = new RestClient
            {
                BaseUrl = new Uri(RequesterUrls.BaseUrl)
            };
        }

        public HttpStatusCode MakeRegistration(string email, string password, string confirmPassword)
        {
            var request = new RestRequest(RequesterUrls.RegistrationPath, Method.POST);
            request.AddParameter("Email", email);
            request.AddParameter("Password", password);
            request.AddParameter("ConfirmPassword", confirmPassword);
            var response = client.Execute(request);
            return response.StatusCode;
        }

        public HttpStatusCode MakeLogin(string username, string password)
        {
            var request = new RestRequest(RequesterUrls.TokenUrl, Method.POST);
            request.AddParameter("Username", username);
            request.AddParameter("Password", password);
            request.AddParameter("grant_type", "password");
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                this.token = JsonConvert.DeserializeObject<ResponseModles.LoginResponse>(response.Content).Token;
                return HttpStatusCode.OK;
            }
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                return HttpStatusCode.BadRequest;
            }

            return HttpStatusCode.Unauthorized;
        }

        public string MakeCreateGame()
        {
            var request = new RestRequest(RequesterUrls.CreateGamePath, Method.POST);
            request.AddHeader("Authorization", "Bearer " + this.token);
            var response = client.Execute(request);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return response.Content;
                case HttpStatusCode.Unauthorized:
                    return ErrorMessage.Unauthorized;
                default:
                    return ErrorMessage.ConnectionProblem;
            }
        }

        public HttpStatusCode MakeJoinGame(string gameId)
        {
            var request = new RestRequest(RequesterUrls.JoinGamePath, Method.POST);
            request.AddParameter("GameId", gameId);
            request.AddHeader("Authorization", "Bearer " + this.token);
            var response = client.Execute(request);
            return response.StatusCode;
        }

        public HttpStatusCode MakePlay(string gameId, int x, int y)
        {
            var request = new RestRequest(RequesterUrls.Play, Method.POST);
            request.AddHeader("Authorization", "Bearer " + this.token);
            request.AddParameter("GameId", gameId);
            request.AddParameter("PositionX", x);
            request.AddParameter("PositionY", y);
            var response = client.Execute(request);
            return response.StatusCode;
        }
    }
}
