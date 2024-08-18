using System.Text.Json.Serialization;

namespace Playground.Configuration;

public record MatchExtensions
{
    [JsonPropertyName("dlls")]
    public string[] DllExtensions { get; init; }
    
    
    [JsonPropertyName("literal-extensions")]
    public TokenExtensions[] Tokens { get; init; }
}
