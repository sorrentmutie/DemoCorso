using System.Text.Json.Serialization;

public class ReqResResponse
{
    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    [JsonPropertyName("data")]
    public User[]? Data { get; set; }

    public Support support { get; set; }
}

public class Support
{
    public string url { get; set; }
    public string text { get; set; }
}

public class User
{
    public int id { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; } = string.Empty;
    [JsonPropertyName("last_name")]
    public string LastName { get; set; } = string.Empty;
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; } = string.Empty;
}
