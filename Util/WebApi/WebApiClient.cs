using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Util.WebApi
{
    public class WebApiClient
    {
        public static WebApiClient Build()
        {
            return new WebApiClient();
        }
        public T Get<T>(string endpoint, string parameters)
        {
            var compiledParameters = MountParameters(parameters);

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri($"https://localhost:44357/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync($"{endpoint}{parameters}").Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<T>().Result;
                }
                else
                {
                    return default(T);
                }
            }
        }

        private string MountParameters(object parameters)
        {
            string param = parameters.ToString();
            return param;
        }

        public T Post<T>(string endpoint, object parameters, T body)
        {
            var compiledParameters = MountParameters(parameters);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync<T>($"{endpoint}{compiledParameters}", body).Result;

                if (response.IsSuccessStatusCode)
                {
                    var contractString = response.Content.ReadAsStringAsync().Result;
                    return response.Content.ReadAsAsync<T>().Result;
                }
                else
                {
                    return default(T);
                }
            }
        }

        public void Post(string endpoint, object parameters)
        {
            var compiledParameters = MountParameters(parameters);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsync($"{endpoint}{compiledParameters}", null).Result;

                if (response.IsSuccessStatusCode)
                {
                    var contractString = response.Content.ReadAsStringAsync().Result;
                    var result = response.Content.ReadAsAsync<string>().Result;
                }
            }
        }
    }
}