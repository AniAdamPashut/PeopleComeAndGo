using Common.Tokenization;
using Tokenizer.Matchers;

namespace TokenizerTestOperatorMatches;

public class PlusEqualsMatcher() : ValueMatcher("+=", TokenType.Operator);

