using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cs_linq
{
    internal class ExtendMethod
    {

        public void show()
        {
            Calcutate calcutate = new Calcutate();
            int result = calcutate.doAdd(1, 2);
            Console.WriteLine($"result is : {result}");
            Console.WriteLine($"===============================================");
            Console.WriteLine($"The following is for testing extend method");
            int result_extendMethod = NewCalcutate.newDoAdd(calcutate,2,4,6);
            Console.WriteLine($"result is : {result_extendMethod}");
        }
    }

    class Calcutate
    {
        public int doAdd(int x, int y)
        {
            return x + y;
        }
    }

    static class NewCalcutate
    {
        public static int newDoAdd(this Calcutate calcutate,int a, int b, int c)
        {
            return a + b + c;
        }
    }



}
