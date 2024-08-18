using System.Text.RegularExpressions;

using Tokenizer.Core;
using Tokenizer.Matchers;

namespace Tokenizer.Extras;

public class SimpleIntegerMatcher() : RegexMatcher(@"^(0|([1-9]+[0-9]*))", RegexOptions.Compiled, TokenType.Literal);

