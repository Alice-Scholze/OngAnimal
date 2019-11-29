using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public T Get<T>(string endpoint, object parameters)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri($"https://localhost:44357/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                parameters = MountParams(parameters);

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

        private String MountParams(object data)
        {
            String[] parameters = new string[] { };

            if (data != null)
            {
                parameters = data.ToString().Split(',');
            }

            String queryParam = String.Empty;

            if (parameters.Length > 0) {
                foreach (var parameter in parameters)
                {
                    queryParam = parameter == parameters[0] ? $"/{parameter}" : $"&{parameter}";
                }
            }

            return queryParam;
        }
        public T Post<T>(string endpoint, T body)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync<T>($"{endpoint}", body).Result;

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

        public T Put<T>(string endpoint, object parameters, T body)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                parameters = MountParams(parameters);

                var response = client.PutAsJsonAsync<T>($"{endpoint}{parameters}", body).Result;

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

        public T Delete<T>(string endpoint, object parameters)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri($"https://localhost:44357/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                parameters = MountParams(parameters);

                var response = client.DeleteAsync($"{endpoint}{parameters}").Result;

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
    }
}