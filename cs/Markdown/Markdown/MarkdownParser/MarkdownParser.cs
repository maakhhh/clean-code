using System.Text;

namespace Markdown;

public class MarkdownParser : IMarkdownParser
{
    private readonly List<ITokenParser> parsers;

    public MarkdownParser(List<ITokenParser> parsers)
    {
        this.parsers = parsers;
    }

    public List<Token> ParseTextToTokens(string text)
    {
        throw new NotImplementedException();
    }
}
