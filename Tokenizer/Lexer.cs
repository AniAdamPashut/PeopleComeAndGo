using Common.Tokenization;

namespace Tokenizer;

public class Lexer(IEnumerable<IMatcher> Matchers)
{
    public int ErrorRange { get; init; } = 10;

    public IEnumerable<Token> Tokenize(string content)
    {
        int index = 0;
        while (index < content.Length)
        {
            Token? current = Matchers
                .Select(matcher => matcher.Match(content[index..]))
                .OfType<Token>()
                .OrderByDescending(token => token.Length)
                .ThenBy(token => token.Type)
                .FirstOrDefault()
                ?? throw new LexerError($"Lexer could not parse the following near \"{
                    content[index..(index + ErrorRange < content.Length ? index + ErrorRange : content.Length)]
                    }\" @ [{index}]");

            yield return current;
            index += current.Length;
        }
    }
}

