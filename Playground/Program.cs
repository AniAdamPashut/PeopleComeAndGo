using Tokenizer;
using Tokenizer.Core;
using Tokenizer.Matchers;

using Playground.Configuration;
using System.Text.Json;
using System.Reflection;

var matchers = new List<IMatcher>()
{
    new WhitespaceMatcher(),
};

using var stream = new FileStream("./config.json", FileMode.Open, FileAccess.Read);
var config = JsonSerializer.Deserialize<Config>(stream);

foreach (var tokenExtensions in config?.TokenizerExtensions.Tokens ?? [])
{
    var creator = new MatcherFactory(Enum.Parse<TokenType>(tokenExtensions.Type));
    foreach (var matcher in creator.CreateValues(tokenExtensions.Lexemes))
    {
        matchers.Add(matcher);
    }
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
string content = "int main() {\n\tprintf(\"Hello, World!\");\n\treturn 0;\n}\n";
Console.WriteLine(content);
var tokens = tokenizer.Tokenize(content);

foreach (var token in tokens.Where(token => token.Type != TokenType.Whitespace))
{
    Console.WriteLine(token);
}