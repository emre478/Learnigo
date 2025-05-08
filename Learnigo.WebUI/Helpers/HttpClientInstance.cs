namespace Learnigo.WebUI.Helpers
{
    public static class HttpClientInstance
    {
        public static HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:7062/api/");

            return client;
        }
    }
}
