using System;
using System.Diagnostics;


// 8888b.  888888  dP""` b8 88 8b d8    db    88       888888  dP"Yb    88""Yb 88 88b 88    db    88""Yb Yb  dP
// 8I  Yb 88__   dP      88 88b  d88   dPYb   88         88   dP   Yb   88__dP 88 88Yb88   dPYb   88__dP  YbdP 
// 8I  dY 88""   Yb      88 88YbdP88  dP__Yb  88  .o     88   Yb   dP   88""Yb 88 88 Y88  dP__Yb  88"Yb    8P  
// 8888Y"  888888 YboodP 88 88 YY 88 dP""""Yb 88ood8     88    YbodP    88oodP 88 88  Y8 dP""""Yb 88  Yb  dP

public class MyProgram
{
    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double ReadValue()
    {
        double resultVal;
        while (!double.TryParse(Console.ReadLine(), out resultVal)) ;
        return resultVal;
    }

    // DecToBin Method
    public static string DecToBin(int num)
    {
        // Variable       
        int i = 0;
        int length = 0;
        string binaryStr = "";

        // Array
        int[] remainder = new int[50];

        // Method to initialize Array remainder     
        InitializeInt(remainder);

        // All the math work here
        while (num > 0)
        {
            remainder[i] = num % 2;
            num = (int)((double)num / 2);
            i = i + 1;
            length = length + 1;
        }

        // Add back to string
        for (i = length - 1; i >= 0; i--)
        {
            binaryStr = binaryStr + remainder[i];
        }
        return binaryStr;
    }

    // Array Initialize
    public static void InitializeInt(int[] binaryArray)
    {
        int iteration, length;
        length = binaryArray.Length;
        for (iteration = 0; iteration <= length - 1; iteration++)
        {
            binaryArray[iteration] = 0;
        }
    }

    public static void Main(string[] args)
    {
        // Declare variable
        int num;
        Console.WriteLine(@"
,-.          ,---.     ,-.       
|  \           |       |  ) o    
|  | ,-. ,-.   |   ,-. |-<  . ;-.
|  / |-' |     |   | | |  ) | | |
`-'  `-' `-'   '   `-' `-'  ' ' '                                                                                                                                     ,                                     

");
        // Console Output
        Console.WriteLine("Enter Decimal Number: ");

        // Read Line & send to ReadValue() method, then call to DecToBin to output
        num = (int)ReadValue();
        Console.WriteLine($"\n Binary is: {DecToBin(num)}");

    }
}
