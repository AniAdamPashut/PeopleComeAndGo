using System.Text.RegularExpressions;

using Tokenizer.Core;
using Tokenizer.Matchers;

namespace Tokenizer.Extras;

public class NameMatcher() : RegexMatcher(@"^[A-Za-z]+[A-Za-z0-9]*", RegexOptions.Compiled, TokenType.Identifier);
