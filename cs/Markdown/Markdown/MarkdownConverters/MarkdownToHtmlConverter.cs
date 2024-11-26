using System.Text;

namespace Markdown;

public class MarkdownToHtmlConverter : IMarkdownConverter
{
    private Dictionary<TokenType, HtmlTokenConverter> converters;

    public MarkdownToHtmlConverter()
    {
        converters = new()
        {
            { TokenType.Bold, new BoldTokenHtmlConverter() },
            { TokenType.Italic, new ItalicTokenHtmlConverter() },
            { TokenType.Header, new HeaderTokenHtmlConverter() },
            { TokenType.SimpleText, new TextTokenHtmlConverter() }
        };
    }

    public string Convert(List<Token> tokens)
    {
        ArgumentNullException.ThrowIfNull(tokens);

        var result = new StringBuilder();

        foreach (var token in tokens)
            result.Append(ConvertToken(token));

        return result.ToString();
    }

    private string ConvertToken(Token token)
    {
        var converter = converters[token.Type];

        if (token is not ComplexToken)
            return converter.Convert(token);

        var result = new StringBuilder();

        result.Append(converter.OpenTag);
        foreach (var child in token.Childs)
        {
            result.Append(ConvertToken(child));
        }
        result.Append(converter.CloseTag);

        return result.ToString();
    }
}