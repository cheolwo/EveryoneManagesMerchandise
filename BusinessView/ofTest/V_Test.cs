//using System.Net.Http.Json;
//using System.Text.Json;

//namespace BusinessView.ofTest
//{
//    public class V_Test
//    {
//        public HttpClient HttpClient { get; set; }
//        public WeatherForecast[] WeatherForecasts { get; set; }
//        public List<WeatherForecast> ListWeatherForecasts { get; set; }
//        public V_Test()
//        {
//            HttpClient = new HttpClient();
//            HttpClient.BaseAddress = new Uri("https://identityserverinplanlogistcs.azurewebsites.net/");
//        }
//        public async Task<IEnumerable<WeatherForecast>> WeatherforecastGet()
//        {
//            var httpResponseMessage = await HttpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("weatherforecast");
//            return httpResponseMessage;
//        }
//        public async Task<List<WeatherForecast>> ListWeatherforecastGet()
//        {
//            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://identityserverinplanlogistcs.azurewebsites.net/weatherforecast");
//            var httpResponseMessage = await HttpClient.SendAsync(httpRequestMessage);
//            if (httpResponseMessage.IsSuccessStatusCode)
//            {
//                using var contentStream =
//                    await httpResponseMessage.Content.ReadAsStreamAsync();

//                ListWeatherForecasts = await JsonSerializer.DeserializeAsync
//                    <List<WeatherForecast>>(contentStream);
//                return ListWeatherForecasts;
//            }
//            return ListWeatherForecasts;
//        }
//    }
//}
