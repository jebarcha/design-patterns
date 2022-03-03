using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Visitor;

//Strategy();
Visitor();

#region Behavioral
void Strategy()
{
    var imageStorage = new ImageStorage();
    imageStorage.store("a", new JpegCompressor(), new BlackAndWhiteFilter());
    imageStorage.store("b", new PngCompressor(), new BlackAndWhiteFilter());
}

void Visitor()
{
    var document = new HtmlDocument();
    document.Add(new HeadingNode());
    document.Add(new AnchorNode());
    document.Execute(new HighlightOperation());
    document.Execute(new PlainTextOperation());
}

#endregion