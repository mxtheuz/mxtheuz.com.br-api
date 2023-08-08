namespace MxtheuzSkillsAPI.Models;

public class PingModel
{
    public TimeSpan ElapsedTime { get; set; }
    public string ResponseCode { get; set; }
    public bool IsSuccess { get; set; }
    public long ContentLengthBytes { get; set; }
}