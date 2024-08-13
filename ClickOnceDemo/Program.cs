// See https://aka.ms/new-console-template for more information

#if DEV
Console.WriteLine("Hello, World! (Dev)");
#else
Console.WriteLine("Hello, World! (Prod)");
#endif

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
