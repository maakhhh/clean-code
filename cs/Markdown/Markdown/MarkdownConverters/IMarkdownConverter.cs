using Markdown.Tokens;

namespace Markdown.MarkdownConverters;

public interface IMarkdownConverter
{
    public string Convert(List<Token> tokens);
}
