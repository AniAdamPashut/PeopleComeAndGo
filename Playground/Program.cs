using Common.Tokenization;

using Tokenizer;
using Tokenizer.Matchers;

using Playground.Configuration;
using System.Text.Json;
using System.Reflection;

var matchers = new List<IMatcher>()
{
    new WhitespaceMatcher(),
    new NameMatcher(),
};

using var stream = new FileStream("./config.json", FileMode.Open, FileAccess.Read);
var config = JsonSerializer.Deserialize<Config>(stream);

var keywordCreator = new MatcherFactory(TokenType.Keyword);
foreach (var matcher in keywordCreator.CreateValues(config?.TokenizerExtensions.Keywords ?? []))
{
    matchers.Add(matcher);
}

var dlls = config?.TokenizerExtensions.DllExtensions ?? [];
foreach (var dllPath in dlls)
{
    var ass = Assembly.LoadFrom(dllPath);
    foreach (var type in ass.GetTypes())
    {
        if (typeof(IMatcher).IsAssignableFrom(type))
        {
            matchers.Add((IMatcher)Activator.CreateInstance(type));
        }
    }
}

var tokenizer = new Lexer(matchers);
var tokens = tokenizer.Tokenize("if\tifa moshe += for while AniAdamPashut");

foreach (var token in tokens)
{
    Console.WriteLine(token);
}