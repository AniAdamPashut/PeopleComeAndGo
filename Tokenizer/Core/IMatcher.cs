namespace Tokenizer.Core;

public interface IMatcher
{
    Token? Match(string toMatch);
}