using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Algorithms
{
    public static class HttpRequest
    {
        public static async Task<object> PostBearerToken()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new Uri("https://randomurl/oauth2/token") })
            {
                var obj = new
                {
                    email = "test@gmail.com",
                    password = "646432"//this object is just example
                };

                var contentLogin = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(client.BaseAddress, contentLogin);
                var accessTokenResult = await response.Content.ReadAsStringAsync();
                var accessToken = JsonConvert.DeserializeObject<AccessToken>(accessTokenResult);
                return new { status = "Success", token = new AccessToken { Access_token = "asdsad" } };
            }
        }

        public static async Task<object> PostParameterWithBearer(string bearerToken, int limit)
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new Uri("https://randomurl/products?bearerToken=" + bearerToken + "&limit=" + limit) })
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", "accessToken");
                var value = await client.GetStringAsync(client.BaseAddress);
                return value;
            }
        }
        public static async Task<object> PostBodyWithBearerToken()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new Uri("https://randomurl/product/add") })
            {
                var login = new
                {
                    CustomerId = "6565544",
                    Pass1 = "sdfret54",
                    Pass2 = "smnrfus2"
                };
                var contentLogin = new StringContent(JsonConvert.SerializeObject(login), encoding: Encoding.UTF8,
                                                  mediaType: "application/json");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "accessToken");
                var logindeger = await client.PostAsync(client.BaseAddress, contentLogin);
                var stringdeger = await logindeger.Content.ReadAsStringAsync();

                return new { status = "Success" };
            }
        }
    }
    public class AccessToken
    {
        public string Access_token { get; set; }
    }
}