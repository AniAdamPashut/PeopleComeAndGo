using System.Text.Json.Serialization;

namespace Playground.Configuration;

[JsonSerializable(typeof(Config))]
public record Config
{
    [JsonPropertyName("tokenizer-extensions")]
    public MatchExtensions TokenizerExtensions { get; init; }

}
