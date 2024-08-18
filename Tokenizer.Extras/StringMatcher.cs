using Tokenizer.Core;
using System.Text.RegularExpressions;
using Tokenizer.Matchers;

namespace Tokenizer.Extras;

public class StringMatcher() : RegexMatcher("^(\".*\")", RegexOptions.Compiled, TokenType.Literal);
