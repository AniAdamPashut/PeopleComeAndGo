using System.Text.Json.Serialization;

namespace Playground.Configuration;

public record TokenExtensions
{
    [JsonPropertyName("lexemes")]
    public string[] Lexemes { get; init; }

    [JsonPropertyName("type")]
    public string Type { get; init; }
}

