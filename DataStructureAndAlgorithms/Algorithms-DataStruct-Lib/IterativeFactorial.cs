using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib;

public class IterativeFactorial
{
    public static int IterativeFactorialMethod(int number)
    {
        if (number == 0) return 1;

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    // 1! = 1 * 0! = 1
    // 2! = 2 * 1 = 2 * 1!
    // 3! = 3 * 2 * 1 = 3 * 2!
    // 4! = 4 * 3 * 2 * 1 = 4 * 3!
    // n! = n * (n - 1)!

    public static int RecursiveFactorial(int n) 
    {
        if (n == 0) { return 1; }

        return n * RecursiveFactorial(n - 1);
    }
}

