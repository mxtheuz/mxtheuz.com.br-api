using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MxtheuzSkillsAPI.Models;
using MxtheuzSkillsAPI.Utils.Services.Interfaces;

namespace MxtheuzSkillsAPI.Controllers;

[Route("api/v2")]
public class APIController : Controller
{
    [HttpGet("skills")]
    public async Task<dynamic> Skills([FromServices] IGistRequest gistRequest)
    {
        Root response = await gistRequest.GetGist("30b00d5caf04860dd1372343547c0260");
        return response.files.skillsjson.content;
    }
    
    [HttpGet("status")]
    public async Task<PingModel> Status([FromServices] IPingService pingService) => await pingService.GetInfos("https://mxtheuz.com.br");
    
}