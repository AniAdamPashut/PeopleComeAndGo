using Common.Tokenization;

namespace Tokenizer.Matchers;

public class IfMatcher : IMatcher
{
    public Token? Match(string toMatch)
    {
        if (toMatch.StartsWith("if"))
        {
            return new("if", TokenType.Keyword);
        }
        return null;
    }
}
