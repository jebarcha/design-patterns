using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Command.Example2;
using DesignPatterns.Behavioral.Command.Example3_UndoableOperations;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Behavioral.Visitor.Demo2;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.app;
using DesignPatterns.Creational.AbstractFactory.Demo2;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Builder.Demo2;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.Demo2;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Creational.Singleton.Demo2;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
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
VisitorDemo2();
//TemplateMethod();
//Command();
//ChainOfResponsibility();
//Memento();
//Iterator();
//Mediator();
//Observer();

#endregion

#region Call Structural
//Facade();
//Adapter();
//Composite();
//Proxy();
//Bridge();
//Decorator();
//Flyweight();
#endregion

#region Call Creational
//AbstractFactory();
//AbstractFactoryDemo2();

//Prototype();
//PrototypeDemo2();

//Singleton();
//SingletonDemo2();

//FactoryMethod();
//FactoryMethodDemo2();

//Builder();
//BuilderDemo2();
#endregion

#region Creational
void FactoryMethod()
{
    new ProductsController().ListProducts();
}
void FactoryMethodDemo2()
{
    Console.WriteLine("Factory Method - Demo2");
    //var scheduler = new Scheduler();
    //scheduler.schedule(new Event());

    // Standard scheduler using the Gregorian calendar
    var scheduler = new Scheduler();
    scheduler.Schedule(new Event());

    // Arabian scheduler using the Arabian calendar
    var arabianScheduler = new ArabianScheduler();
    arabianScheduler.Schedule(new Event());
}

void Prototype()
{
    Console.WriteLine("Prototype Pattern - Demo 1");
    var newComponent = new ContextMenu();
    newComponent.Duplicate(new Circle());
    newComponent.Duplicate(new Square());
}
void PrototypeDemo2()
{
    Console.WriteLine("Prototype Pattern - Demo 2");
    var timeline = new DesignPatterns.Creational.Prototype.Demo2.Timeline();
    var text = new DesignPatterns.Creational.Prototype.Demo2.Text("Hello");
    timeline.Add(text);

    var menu = new DesignPatterns.Creational.Prototype.Demo2.ContextMenu(timeline);
    menu.Duplicate(text);

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
void SingletonDemo2()
{
    var logger1 = MyLogger.GetInstance("file1");
    var logger2 = MyLogger.GetInstance("file1");
    Console.WriteLine(logger1 == logger2);

    var logger3 = MyLogger.GetInstance("file2");
    Console.WriteLine(logger1 == logger3);
}

void AbstractFactory()
{
    Console.WriteLine("Abstract Factory Pattern");
    new ContactForm().Render(new MaterialWidgetFactory());

    new ContactForm().Render(new AntWidgetFactory());
}
void AbstractFactoryDemo2()
{
    var homePage = new HomePage();
    //homePage.SetGoal(Goal.WEIGHT_LOSS);
    homePage.SetGoal(new WeightLossFactory());
    homePage.SetGoal(new BuildMuscleFactory());
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
void BuilderDemo2()
{
    var document = new Document();
    document.Add(new DesignPatterns.Creational.Builder.Demo2.Text("hola"));
    document.Add(new DesignPatterns.Creational.Builder.Demo2.Image("pic1.jpg"));

    document.Export(new HtmlDocumentBuilder(), "export.html");

    // Only writes the text elements to the file
    document.Export(new TextDocumentBuilder(), "export.txt");


    //var document = new Document();
    //document.Add(new DesignPatterns.Creational.Builder.Demo2.Text("hola"));
    //document.Add(new DesignPatterns.Creational.Builder.Demo2.Image("pic1.jpg"));

    //document.Export(ExportFormat.HTML, "export.html");

    //// Only writes the text elements to the file
    //document.Export(ExportFormat.TEXT, "export.txt");
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
    //var docWithProblem = new DesignPatterns.Behavioral.Visitor.TheProblem.HtmlDocument();
    //docWithProblem.Add(new DesignPatterns.Behavioral.Visitor.TheProblem.HeadingNode());
    //docWithProblem.Add(new DesignPatterns.Behavioral.Visitor.TheProblem.AnchorNode());
    //docWithProblem.Highlight();
    
    //Refactored using Visitor Design Pattern:
    var document = new DesignPatterns.Behavioral.Visitor.HtmlDocument();
    document.Add(new HeadingNode());
    document.Add(new AnchorNode());
    document.Execute(new HighlightOperation());
    document.Execute(new PlainTextOperation());
}
void VisitorDemo2()
{
    var wavFile = WavFile.Read("myfile.wav");
    wavFile.applyFilter(new NoiseReductionFilter());
    wavFile.applyFilter(new ReverbFilter());
    wavFile.applyFilter(new NormalizeFilter());
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
void Iterator()
{
    Console.WriteLine("Iterator Design Pattern");
    var history = new BrowseHistory();
    history.Push("a");
    history.Push("b");
    history.Push("c");

    IIterator<string> iterator = history.CreateIterator();
    while (iterator.HasNext())
    {
        var url = iterator.Current();
        Console.WriteLine(url);
        iterator.Next();
    }

    // With the Problem
    //for (int i = 0; i < history.GetUrls().Count; i++)
    //{
    //    var url = history.GetUrls()[i];
    //    Console.WriteLine(url);
    //}

}
void Mediator()
{
    Console.WriteLine("Mediator Design Pattern");
    var dialog = new ArticlesDialogBox();
    dialog.SimulateUserInteraction();
}
void Observer()
{
    var dataSource = new DataSource();
    var sheet1 = new SpreadSheet(dataSource);
    var sheet2 = new SpreadSheet(dataSource);
    var chart = new Chart(dataSource);

    dataSource.AddObserver(sheet1);
    dataSource.AddObserver(sheet2);
    dataSource.AddObserver(chart);

    dataSource.SetValue(1);
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
    var imageView = new ImageView(new DesignPatterns.Structural.Adapter.Image());
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
    Console.WriteLine("Decorator Design Pattern");
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
void Flyweight()
{
    Console.WriteLine("Flyweight Design Pattern");
    // With this implementation we are storing our object in a single place in memory
    var service = new PointService(new PointIconFactory());
    foreach (var point in service.GetPoints())
    {
        point.Draw();
    }

    // With The Problem:
    //var service = new PointService();
    //foreach (var point in service.GetPoints())
    //{
    //    point.Draw();
    //}
}
#endregion

//static bool IsCont(int FileType)
//{
//    var fileTypesContinuousContent = new List<int>() { 10007, 10008, 10009, 10010 };
//    return fileTypesContinuousContent.Contains(FileType);
//}