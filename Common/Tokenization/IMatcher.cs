namespace Common.Tokenization;

public interface IMatcher
{
    Token? Match(string toMatch);
}