using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Command.Example2;
using DesignPatterns.Behavioral.Command.Example3_UndoableOperations;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.app;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Proxy;

//if (IsCont(10007))
//    Console.WriteLine("IsCont");
//else
//    Console.WriteLine("Is not Cont");
//return;

#region Call Behavioral
//Strategy();
//State();
//Visitor();
//TemplateMethod();
//Command();
//ChainOfResponsibility();
//Memento();

#endregion

#region Call Structural
//Facade();
//Adapter();
//Composite();
//Proxy();
//Bridge();
Decorator();


#endregion

#region Call Creational
//AbstractFactory();
//Prototype();
//Singleton();
//FactoryMethod();
//Builder();
#endregion

#region Creational
void FactoryMethod()
{
    
}
void Prototype()
{
    Console.WriteLine("Prototype Pattern");
    var circle = new ContextMenu();
    circle.Duplicate(new Circle());

}
void Singleton()
{
    Console.WriteLine("Singleton Pattern");
    ConfigManager manager = ConfigManager.GetInstance();
    manager.Set("name", "Jose");
    Console.WriteLine(manager.Get("name"));

    ConfigManager other = ConfigManager.GetInstance();
    Console.WriteLine(other.Get("name"));

    // With the problem:
    //ConfigManager manager = new ConfigManager();
    //manager.Set("name", "Jose");

    //ConfigManager other = new ConfigManager();
    //Console.WriteLine(other.Get("name"));
}
void AbstractFactory()
{
    Console.WriteLine("Abstract Factory Pattern");
    new ContactForm().Render(new MaterialWidgetFactory());

    new ContactForm().Render(new AntWidgetFactory());
}
void Builder()
{
    var presentation = new Presentation();
    presentation.AddSlide(new Slide("Slide 1"));
    presentation.AddSlide(new Slide("Slide 2"));

    var builder = new PdfDocumentBuilder();
    presentation.Export(builder);
    var pdf = builder.GetPdfDocument();
    //Console.WriteLine(pdf);

    var builderMovie = new MovieBuilder();
    presentation.Export(builderMovie);
    var movie = builderMovie.GetMovie();
    //Console.WriteLine(movie);
}
#endregion

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
void Command()
{
    // Button
    // Checkbox
    // Textbox
    //Example 1
    //Console.WriteLine("Example 1");
    //var service = new CustomerService();
    //var command = new AddCustomerCommand(service);
    //var button = new Button(command);
    //button.Click();

    //Console.WriteLine("\nExample 2-Composite Command");
    //// Example 2 Composite Command Example:
    //var composite = new CompositeCommand();
    //composite.Add(new BlackAndWhiteCommand());
    //composite.Add(new ResizeCommand());
    //composite.Execute();
    //composite.Execute();

    // Example 3 - Undoable operations
    Console.WriteLine("\nExample 3-Undoable Command");
    var history = new DesignPatterns.Behavioral.Command.Example3_UndoableOperations.History();
    var document = new DesignPatterns.Behavioral.Command.Example3_UndoableOperations.HtmlDocument();
    document.Content = "Hello World";

    var boldCommand = new DesignPatterns.Behavioral.Command.Example3_UndoableOperations.BoldCommand(document, history);
    boldCommand.Execute();
    Console.WriteLine(document.Content);

    //boldCommand.UnExecute();
    //Console.WriteLine(document.Content);
    var undoCommand = new UndoCommand(history);
    undoCommand.Execute();
    Console.WriteLine(document.Content);
}
void ChainOfResponsibility()
{
    // Example 1 with a logger:
    // authenticator -> logger -> compressor
    //var compressor = new Compressor(null);  //this is the last handler in the chain, so create it first.
    //var logger = new Logger(compressor);
    //var authenticator = new Authenticator(logger);

    //var server = new WebServer(authenticator); //here we pass our first handler
    //server.Handle(new HttpRequest("admin", "123456"));


    // Exmaple 2 with an encryptor
    // authenticator->encryptor->compressor
    var encryptor = new Encryptor(null); //this is the last handler in the chain, so create it first.
    var compressor2 = new Compressor(encryptor);
    var authenticator2 = new Authenticator(compressor2);

    var server2 = new WebServer(authenticator2); //here we pass our first handler
    server2.Handle(new HttpRequest("admin", "123456"));
}
void Memento()
{
    var editor = new Editor();
    var history = new DesignPatterns.Behavioral.Memento.History();

    editor.SetContent("a");
    history.Push(editor.CreateState());

    editor.SetContent("b");
    history.Push(editor.CreateState());

    editor.SetContent("c");
    editor.Restore(history.Pop());

    Console.WriteLine(editor.GetContent());
    editor.Restore(history.Pop());
    Console.WriteLine(editor.GetContent());
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
void Adapter()
{
    var imageView = new ImageView(new Image());
    imageView.Apply(new VividFilter());
    //imageView.Apply(new Caramel());  // error because the thirparty does not implement our IFilter interface
    imageView.Apply(new CaramelFilterAdapter(new Caramel()));
}
void Composite()
{
    var group1 = new Group();
    group1.Add(new Shape()); // our imaginary square
    group1.Add(new Shape()); // our imaginary square

    var group2 = new Group();
    group2.Add(new Shape()); // our imaginary circle
    group2.Add(new Shape()); // our imaginary circle

    var group = new Group();
    group.Add(group1);  //with this structure we cannot add a group inside a group
    group.Add(group2);
    group.Render();
    group.Move();

    
}
void Proxy()
{
    var library = new Library();
    string[] fileNames = { "a", "b", "c" };
    foreach (var fileName in fileNames)
    {
        //library.Add(new EbookProxy(fileName));  // example 1
        library.Add(new LoggingEbookProxy(fileName));  // example 2
        // with the problem:
        //library.Add(new RealEbook(fileName));
    }

    library.OpenEbook("a");
    library.OpenEbook("b");
}
void Bridge()
{
    Console.WriteLine("Bridge Design Pattern");
    var remoteControl = new RemoteControl(new SonyTV());
    remoteControl.TurnOn();

    var advRemoteControl = new AdvancedRemoteControl(new SonyTV());
    advRemoteControl.TurnOn();

    var samsung = new AdvancedRemoteControl(new SamsungTV());
    samsung.TurnOn();
}
void Decorator()
{
    StoreCreditCard(new CloudStream());

    StoreCreditCard(new EncryptedCloudStream(new CloudStream()));  //wrapping or decorating our CloudStream with the EnryptedCloudStream

    StoreCreditCard(new CompressCloudStream(new CloudStream()));

    StoreCreditCard(new EncryptedCloudStream(new CompressCloudStream(new CloudStream())));

    //With the problem:
    //var cloudStream = new EncryptedCloudStream(); //CloudStream();
    //cloudStream.Write("Hello World");
}
static void StoreCreditCard(IStream stream)
{
    stream.Write("1234-1234-1234-1234");
}
#endregion

//static bool IsCont(int FileType)
//{
//    var fileTypesContinuousContent = new List<int>() { 10007, 10008, 10009, 10010 };
//    return fileTypesContinuousContent.Contains(FileType);
//}