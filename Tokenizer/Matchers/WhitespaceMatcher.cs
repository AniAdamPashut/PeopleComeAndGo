using System.Text.RegularExpressions;

using Tokenizer.Core;

namespace Tokenizer.Matchers;

public class WhitespaceMatcher() : RegexMatcher(@"^\s+", RegexOptions.Compiled, TokenType.Whitespace);

