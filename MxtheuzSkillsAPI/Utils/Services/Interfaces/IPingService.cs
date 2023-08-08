using MxtheuzSkillsAPI.Models;

namespace MxtheuzSkillsAPI.Utils.Services.Interfaces;

public interface IPingService
{
    public Task<PingModel> GetInfos(string url);
}