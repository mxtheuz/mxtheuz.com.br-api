namespace MxtheuzSkillsAPI.Utils.Services.Interfaces;

public interface IGistRequest
{
    public Task<dynamic> GetGist(string gistId);
}