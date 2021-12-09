using ConsoleApp1;

ScaryScary fingersTheClown = new ScaryScary("duże buty", 35);
FunnyFunny someFunnyClown = fingersTheClown;
IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
someOtherScaryClown.Honk();
Console.ReadKey();