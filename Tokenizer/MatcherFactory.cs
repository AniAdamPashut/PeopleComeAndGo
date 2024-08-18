using System.Text.RegularExpressions;

using Tokenizer.Core;
using Tokenizer.Matchers;

namespace Tokenizer;

public class MatcherFactory(TokenType Type)
{
    public IEnumerable<IMatcher> CreateValues(IEnumerable<string> values)
    {
        foreach (var value in values)
        {
            yield return new ValueMatcher(value, Type);
        }
    }

    public IEnumerable<IMatcher> CreateRegex(IEnumerable<string> patterns, RegexOptions opt)
    {
        foreach (var pattern in patterns)
        {
            yield return new RegexMatcher(pattern, opt, Type);
        }
    }
}

