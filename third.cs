int Main()
{
    int m = 0, n = 0;
    
    Console.WriteLine("Program is running.\n" + 
    "Enter two numbers to calculate Ackermann function. A(m,n).\n" +
    "Enter m.");
    
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter n.");
    n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Ackermann function for A({m},{n}) = {AckermannFunction(m,n)}");
    Console.WriteLine("To terminate a program enter 0");
    if(Console.ReadLine() != "0")
        Main();
    return 0;
}

Main();


int AckermannFunction(int m, int n)
{
        if(m == 0) return n + 1;
        if(m != 0 && n == 0) return AckermannFunction(m-1,1);
        if(m > 0 && n > 0)  return AckermannFunction(m-1, AckermannFunction(m,n-1));
    return AckermannFunction(m,n);
}
