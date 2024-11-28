using Microsoft.Extensions.DependencyInjection;

namespace Markdown;

public static class Program
{
    public static void Main()
    {
        var services = new ServiceCollection();

        services.AddSingleton<IMarkdownConverter, MarkdownToHtmlConverter>();
        services.AddSingleton<IMarkdownParser, MarkdownParser>();
        services.AddSingleton<ITokenParser, BoldTokenParser>();
        services.AddSingleton<ITokenParser, HeaderTokenParser>();
        services.AddSingleton<ITokenParser, ItalicTokenParser>();
        services.AddSingleton<Md>();

        var sp = services.BuildServiceProvider();
        var md = sp.GetService<Md>();
    }
}
