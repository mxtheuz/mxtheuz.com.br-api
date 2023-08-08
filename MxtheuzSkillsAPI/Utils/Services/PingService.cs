using System.Diagnostics;
using MxtheuzSkillsAPI.Models;
using MxtheuzSkillsAPI.Utils.Services.Interfaces;

namespace MxtheuzSkillsAPI.Utils.Services;

public class PingService : IPingService
{
    public async Task<PingModel> GetInfos(string url)
    {
        try
        {
            var httpClient = new HttpClient();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var response = await httpClient.GetAsync(url);
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            bool success = response.IsSuccessStatusCode;
            string responseCode = response.StatusCode.ToString();
            long contentLength = response.Content.Headers.ContentLength ?? 0;

            return new PingModel() { IsSuccess = success, ResponseCode = responseCode, ContentLengthBytes = contentLength, ElapsedTime = elapsedTime};
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }
        return new PingModel() { IsSuccess = false };
    }
}