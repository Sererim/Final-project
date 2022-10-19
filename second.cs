int Main()
{
    int[] num = new int[3];
    string load = "2";
    
    Console.WriteLine("Program is running.\n" + 
    "M must be smaller than N. Example M = 1, N = 10.\n" +
    "Enter M.");
    
    load = Console.ReadLine();
    num[0] = System.Int32.Parse(load);
    
    Console.WriteLine("Enter N.");
    load = Console.ReadLine();
    num[1] = System.Int32.Parse(load);

    if(num[0] < 0 || num[1] < 0 || (num[0] == 0 && num[1] == 0) || num[0] == num[1])
        Main();

    num[2] = 0;
    Recurs(num);

    Console.WriteLine("To terminate a program enter 0");
    load = Console.ReadLine();
    if(load != "0")
        Main();
    return 0;
}

Main();


void Recurs(int[] num)
{
    num[2] += num[1];
    num[1]--;
    if(num[1] < num[0])
        Console.WriteLine($"Sum is {num[2]}.");
    else
        Recurs(num);
}
