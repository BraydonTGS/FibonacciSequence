 static void nthFibonacci(int nthTerm)
{
    int number1 = 0;
    int number2 = 1;
    int nthNumber;

    if(nthTerm == 0)
    {
        Console.WriteLine("Term #0: 0");
    }
    else if (nthTerm == 1)
    {
        Console.WriteLine("Term #1: 1"); 
    }
    else
    {
        for(int i = 0; i < nthTerm; i++)
        {
            Console.WriteLine("Term #" + i + ": " + number1);
            nthNumber = number1 + number2;
            number1 = number2;
            number2 = nthNumber; 
        }
    }
}

while (true)
{

    try
    {
        // Prompt the user //
        Console.Write("Please Enter a number to calculate: ");
        int nthNumber = int.Parse(Console.ReadLine());
        // Calculate Fib //
        nthFibonacci(nthNumber); 
    }

    catch
    {
        Console.WriteLine("Invalid Number. Please Try Again"); 
    }
}

