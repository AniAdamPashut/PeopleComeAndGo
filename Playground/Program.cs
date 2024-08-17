using Common.Tokenization;

using Tokenizer;
using Tokenizer.Matchers;

var matchers = new List<IMatcher>()
{
    new WhitespaceMatcher(),
    new NameMatcher(),
};

var tokenizer = new Lexer(matchers);
var tokens = tokenizer.Tokenize("if\tifa moshe Moshe8 AniAdamPashut");

foreach (var token in tokens)
{
    Console.WriteLine(token);
}