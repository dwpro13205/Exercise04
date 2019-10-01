using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello github");
        }
        // input : float x
        // output : the lowest int n near x but not smaller than x
        // idea : a =( int ) x then a = a +1
         // if x negative
         // if x = a 
        public static int Ceil(float x)
        {
            int a = (int)x;
            if (x > 0)
                if (x>a)
                a = a + 1;
            return a ;
        } 
         // input : float x
         // output : int b is the highest b near x but not greater than x
         // idea : b = ( int ) x then b = b -1
         // if x negative b= b+1
         // if x = b then unchange
        public static int Floor(float x)
        {
            int b = (int)x;
            if (b < 0 && b != b )

                b = b -1;
            return b;
        }
    }
}
