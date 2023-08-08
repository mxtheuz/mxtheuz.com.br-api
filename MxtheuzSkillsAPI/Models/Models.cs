using Newtonsoft.Json;
public class ChangeStatus
{
    public int total { get; set; }
    public int additions { get; set; }
    public int deletions { get; set; }
}

public class Files
{
    [JsonProperty("skills.json")] public SkillsJson skillsjson { get; set; }
}

public class History
{
    public User user { get; set; }
    public string version { get; set; }
    public DateTime committed_at { get; set; }
    public ChangeStatus change_status { get; set; }
    public string url { get; set; }
}

public class Owner
{
    public string login { get; set; }
    public int id { get; set; }
    public string node_id { get; set; }
    public string avatar_url { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string html_url { get; set; }
    public string followers_url { get; set; }
    public string following_url { get; set; }
    public string gists_url { get; set; }
    public string starred_url { get; set; }
    public string subscriptions_url { get; set; }
    public string organizations_url { get; set; }
    public string repos_url { get; set; }
    public string events_url { get; set; }
    public string received_events_url { get; set; }
    public string type { get; set; }
    public bool site_admin { get; set; }
}

public class Root
{
    public string url { get; set; }
    public string forks_url { get; set; }
    public string commits_url { get; set; }
    public string id { get; set; }
    public string node_id { get; set; }
    public string git_pull_url { get; set; }
    public string git_push_url { get; set; }
    public string html_url { get; set; }
    public Files files { get; set; }
    public bool @public { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public string description { get; set; }
    public int comments { get; set; }
    public object user { get; set; }
    public string comments_url { get; set; }
    public Owner owner { get; set; }
    public List<object> forks { get; set; }
    public List<History> history { get; set; }
    public bool truncated { get; set; }
}

public class SkillsJson
{
    public string filename { get; set; }
    public string type { get; set; }
    public string language { get; set; }
    public string raw_url { get; set; }
    public int size { get; set; }
    public bool truncated { get; set; }
    public string content { get; set; }
}

public class User
{
    public string login { get; set; }
    public int id { get; set; }
    public string node_id { get; set; }
    public string avatar_url { get; set; }
    public string gravatar_id { get; set; }
    public string url { get; set; }
    public string html_url { get; set; }
    public string followers_url { get; set; }
    public string following_url { get; set; }
    public string gists_url { get; set; }
    public string starred_url { get; set; }
    public string subscriptions_url { get; set; }
    public string organizations_url { get; set; }
    public string repos_url { get; set; }
    public string events_url { get; set; }
    public string received_events_url { get; set; }
    public string type { get; set; }
    public bool site_admin { get; set; }
}