﻿using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Structural.Facade;

//Strategy();
//State();
//Visitor();
TemplateMethod();



//Facade();

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
void TemplateMethod()
{
    var task = new TransferMoneyTask();
    task.Execute();
}
#endregion

#region Structural
void Facade()
{
    var service = new NotificationService();
    service.Send("Hello World", "target");

    //var server = new NotificationServer();
    //var connection = server.Connect("ip");
    //var authToken = server.Authenticate("appID", "key");
    //var message = new Message("Hello World");
    //server.Send(authToken, message, "target");
    //connection.Disconnect();

}
#endregion