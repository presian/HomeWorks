namespace ConsumeServicesWithCSharp
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public static class Requester
    {
        private static HttpClient client; 

        static Requester()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Utility.BaseUrl);
        }

        public static Task<string> MakeGetRequest(string serviceUrl)
        {
            var request = MakeRequest(serviceUrl, HttpMethod.Get);
            return client.SendAsync(request).ContinueWith(t =>
            {
                var response = t.Result;
                var content = response.Content.ReadAsStringAsync().Result;
                
                return content;
            });
        }

        private static HttpRequestMessage MakeRequest(string serviceUrl, HttpMethod method)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(Utility.BaseUrl + serviceUrl),
                Method = method,
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(Utility.MediaType));
            return request;
        }

        public static Task<string> MakePostRequest(string url, object data)
        {
            var request = MakeRequest(url, HttpMethod.Post);
            var json = JsonConvert.SerializeObject(data);
            request.Content = new StringContent(json);
            request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue(Utility.MediaType);

            return client.SendAsync(request).ContinueWith(
                t =>
                {
                    var response = t.Result;
                    return response.Content.ReadAsStringAsync().Result;
                });

        }

        public static Task<string> MakePutRequest(string url, object data)
        {
            var request = MakeRequest(url, HttpMethod.Put);
            var json = JsonConvert.SerializeObject(data);
            request.Content = new StringContent(json);
            request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue(Utility.MediaType);
            return client.SendAsync(request).ContinueWith(
                t =>
                {
                    var response = t.Result;
                    return response.Content.ReadAsStringAsync().Result;
                });
        }

        public static Task<string> MakeDeleteRequest(string url)
        {
            var request = MakeRequest(url, HttpMethod.Delete);

            return client.SendAsync(request).ContinueWith(
                t =>
                {
                    var response = t.Result;
                    return response.Content.ReadAsStringAsync().Result;
                });
        }

    }
}
