using System.Text.RegularExpressions;

using Common.Tokenization;

namespace Tokenizer.Matchers;

public class NameMatcher() : RegexMatcher(@"^[A-Za-z]+[A-Za-z0-9]*", RegexOptions.Compiled, TokenType.Identifier);
