using Markdown.MarkdownConverters;

namespace Markdown;

public class Md
{
    private readonly IMarkdownConverter converter;

    public Md(IMarkdownConverter converter)
    {
        this.converter = converter;
    }

    public string Render(string markdown)
    {
        var tokens = MarkdownParser.ParseTextToTokens(markdown);
        return converter.Convert(tokens);
    }
}
