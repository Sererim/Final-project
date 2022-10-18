int Main()
{
    int N = 0;
    string load = "2";
    
    Console.WriteLine("Program is running.\nEnter N.");
    load = Console.ReadLine();
    N = System.Int32.Parse(load);
    Console.WriteLine($"{N}");
    
    if(N < 0)
        Main();

    Recurs(N);

    Console.WriteLine("To terminate a program enter 0");
    load = Console.ReadLine();
    if(load != "0")
        Main();
    return 0;
}

Main();


void Recurs(int N)
{
    if(N == 0)
        Console.WriteLine();
    Console.Write($"{N} ");
    
    if(N != 0)
        Recurs(N-1);
}