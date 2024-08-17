using System.Text.RegularExpressions;

using Common.Tokenization;

namespace Tokenizer.Matchers;

public class WhitespaceMatcher : IMatcher
{

    private readonly Regex _regex;

    public WhitespaceMatcher()
    { 
        string pat = @"^\s+";

        _regex = new(pat, RegexOptions.Compiled);
    }

    public Token? Match(string toMatch)
    {
        var match = _regex.Match(toMatch);
        if (match.Success)
        {
            return new Token(match.Value, TokenType.Whitespace);
        }
        return null;
    }
}

