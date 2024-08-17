using System.Text.RegularExpressions;

using Common.Tokenization;

namespace Tokenizer.Matchers;

public class WhitespaceMatcher() : RegexMatcher(@"^\s+", RegexOptions.Compiled, TokenType.Whitespace);

