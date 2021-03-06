# Peafowl ![Logo](https://github.com/selcukgural/Peafowl/blob/main/image/64px.png)

<br>Peafowl is **very simple** and **extensibility** console color helper for .Net applications. 

Peafowl is a [NuGet](https://www.nuget.org/packages/Peafowl/1.0.0) library that you can add in to your project.
<br>
`Install-Package Peafowl`

#### Basics

``` csharp
using Console = Peafowl.Console;
``` 
After you can use predefined writers with default colors.
``` csharp
Console.Info.WriteLine("Info!");
Console.Critical.WriteLine("Critical!");
Console.Error.WriteLine("Error!");
Console.Fatal.WriteLine("Fatal!");
```

![Output](https://github.com/selcukgural/Peafowl/blob/main/image/Capture.PNG)
<br><br>Also you can change predefined writers `Foreground` or `Background` color.
``` csharp
Console.Info.ChangeBackgroundColor(ConsoleColor.Cyan);
Console.Info.ChangeForegroundColor(ConsoleColor.DarkBlue);
Console.Info.WriteLine("Info!");
```
<br>Now best part...you can define own output class. You just need implement `Writer` class to your class

``` csharp
public abstract class Writer
```

``` csharp
public class Debug : Writer
{
    public Debug()
    {
        // Your default output color. You can change any time
        ChangeForegroundColor(ConsoleColor.DarkGray);
    }
}

static void Main(string[] args)
{
    //Now register your Debug class like this
    Console.Register("debug", new Debug());
    //or like this
    Console.Register<Debug>("debug");

    //And now you can call anywhere like this
    Console.Get<Debug>("debug").WriteLine("Debug!");
    //or like this
    Debug debug = Console.Get<Debug>("debug");
    debug.WriteLine("Hello from my Debug class!");
}
```
