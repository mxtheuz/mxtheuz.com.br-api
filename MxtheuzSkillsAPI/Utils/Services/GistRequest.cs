using System.Net.Http.Headers;
using MxtheuzSkillsAPI.Utils.Services.Interfaces;
using Newtonsoft.Json;

namespace MxtheuzSkillsAPI.Utils.Services;

public class GistRequest : IGistRequest
{
    private readonly string GITHUB_TOKEN = "YOUR_GITHUB_APIKEY";

    public async Task<dynamic> GetGist(string gistId)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                using (var requestMessage =
                       new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/gists/" + gistId))
                {
                    requestMessage.Headers.Authorization =
                        new AuthenticationHeaderValue("Bearer", GITHUB_TOKEN);
                    httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("AppName", "1.0"));
    
                    HttpResponseMessage message = await httpClient.SendAsync(requestMessage);
                    var res = await message.Content.ReadAsStringAsync();
                    Root response = JsonConvert.DeserializeObject<Root>(res);
                    return response;
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }

        return false;
    }
}