using System.Text.RegularExpressions;

using Common.Tokenization;

namespace Tokenizer.Matchers;

public class NameMatcher : IMatcher
{

    Regex _regex;

    public NameMatcher()
    {
        string pat = @"^[A-Za-z]+[A-Za-z0-9]*";

        _regex = new(pat, RegexOptions.Compiled);
    }

    public Token? Match(string toMatch)
    {
        var match = _regex.Match(toMatch);
        if (match.Success)
        {
            return new Token(match.Value, TokenType.Identifier);
        }
        return null;
    }
}

