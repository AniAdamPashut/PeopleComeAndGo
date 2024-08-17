using System.Text.RegularExpressions;

using Common.Tokenization;

namespace Tokenizer.Matchers;

public class RegexMatcher(string Pattern, RegexOptions Options, TokenType Type) : IMatcher
{

    private readonly Regex _regex = new(Pattern, Options);

    public Token? Match(string toMatch)
    {
        var match = _regex.Match(toMatch);
        if (match.Success)
        {
            return new Token(match.Value, Type);
        }
        return null;
    }
}

