namespace Markdown.Tokens;

public class Token
{
    public readonly string Content;
    public readonly TokenType Type;
    public readonly List<Token>? childrens;

    public Token(string content, TokenType type, List<Token>? childrens = null)
    {
        Content = content;
        Type = type;
        this.childrens = childrens;
    }
}
