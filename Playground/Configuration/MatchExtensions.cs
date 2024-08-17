using System.Text.Json.Serialization;

namespace Playground.Configuration;

public record MatchExtensions
{
    [JsonPropertyName("dlls")]
    public string[] DllExtensions { get; init; }
    
    
    [JsonPropertyName("keywords")]
    public string[] Keywords { get; init; }
}
