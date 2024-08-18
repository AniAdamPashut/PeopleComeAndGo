using Tokenizer.Core;

namespace Tokenizer.Matchers;

public class ValueMatcher(string Value, TokenType Type) : IMatcher
{
    public Token? Match(string toMatch)
    {
        if (toMatch.StartsWith(Value))
            return new Token(Value, Type);
        return null;
    }
}

