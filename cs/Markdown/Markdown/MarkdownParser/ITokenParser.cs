namespace Markdown;

public interface ITokenParser
{
    public Token ParseStringToToken(string value);
    public int? TryFindTokenStartPosition(string text);
}
