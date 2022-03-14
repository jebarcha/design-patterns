using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Visitor;

//Strategy();
//State();
Visitor();

#region Behavioral
void Strategy()
{
    var imageStorage = new ImageStorage();
    imageStorage.store("a", new JpegCompressor(), new BlackAndWhiteFilter());
    imageStorage.store("b", new PngCompressor(), new BlackAndWhiteFilter());
}

void State()
{
    var canvas = new Canvas();
    canvas.SetCurrentTool(new SelectionTool());
    canvas.MouseDown();
    canvas.MouseUp();

    canvas.SetCurrentTool(new BrushTool());
    canvas.MouseDown();
    canvas.MouseUp();

    canvas.SetCurrentTool(new EraserTool());
    canvas.MouseDown();
    canvas.MouseUp();

void Visitor()
{
    var document = new HtmlDocument();
    document.Add(new HeadingNode());
    document.Add(new AnchorNode());
    document.Execute(new HighlightOperation());
    document.Execute(new PlainTextOperation());
}

}

void Visitor()
{
    var docWithProblem = new DesignPatterns.Behavioral.Visitor.TheProblem.HtmlDocument();
    docWithProblem.Add(new DesignPatterns.Behavioral.Visitor.TheProblem.HeadingNode());
    docWithProblem.Add(new DesignPatterns.Behavioral.Visitor.TheProblem.AnchorNode());
    docWithProblem.Highlight();
    
    //Refactored using Visitor Design Pattern:
    //var document = new HtmlDocument();
    //document.Add(new HeadingNode());
    //document.Add(new AnchorNode());
    //document.Execute(new HighlightOperation());
    //document.Execute(new PlainTextOperation());
}

#endregion