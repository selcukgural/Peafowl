# Peafowl
 
Peafowl is **very simple** and **extensibility** for .Net and .Net Core applications Console output library.

#### Basics

``` csharp
using Console = Peafowl.Console;
``` 
<br>After you can use predefined writers with default colors.
``` csharp
Console.Info.WriteLine("Info!");
Console.Critical.WriteLine("Critical!");
Console.Error.WriteLine("Error!");
Console.Fatal.WriteLine("Fatal!");
```
