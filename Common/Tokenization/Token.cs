namespace Common.Tokenization;

public record Token(string Lexeme, TokenType Type)
{
    public int Length => Lexeme.Length;
}