ActiveWorlds Super-SDK by Roy Curtis

Adapted from the AW.NET wrapper by ByteMR

# Directory structure
Structure is as follows:

* **AWSSDK** : Directory for the VS2012 project for the main AWSSDK
* **SampleBot** : Directory for the VS2012 project for various bot samples
* **AW.Core** : A copy of [changeset 69e50a11848c](http://awnet.codeplex.com/SourceControl/changeset/view/69e50a11848c) of the AW.NET wrapper that is adapted and optimizied for .NET 4.5
* **Build** : The binary output and distribution directory
* **Licenses** : Licenses of used components
* **AWSSDK.sln** : VS2012 main solution
* **FetchLibs.sh** : Shell script to fetch AW SDK native DLLs from official website

# Planned implementation design/samples

* Simple bot that says hello:

```csharp
var bot = new Bot
{
    Name = "Samantha",
    PrivNumber = 888,
    PrivPassword = "myppw"
}.Login().Goto("Droog 0n 0e");

bot.Say("Hello!");
bot.Exit();
```

* Get five earliest built objects from cell

```csharp
var bot = new Bot
{
    Name = "Samantha",
    PrivNumber = 888,
    PrivPassword = "myppw"
}.Login().Goto("Droog 0n 0e");

var cell = (from obj in bot.Query.ObjectsAt("0n 0e")
   where obj.Type = Entities.Object
   orderby obj.Timestamp, obj.Name ascending
   select obj.Model).Take<string>(5);

foreach (model in cell) Console.WriteLine(model);
bot.Exit();
```