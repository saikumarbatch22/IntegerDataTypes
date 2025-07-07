using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDataTypes
{
    /*
     * Integer Data Types:
     * Integer data types are used to store whole numbers (both positive and negative).
     * singed int:
     * -2147483648 to2147483647
     * sizeof int is 4 bytes
     * Base type is System.Int32
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50000;
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine("int min value is: " + int.MinValue);
            Console.WriteLine("int max value is: " + int.MaxValue);
            Console.WriteLine("Size of int is: " + sizeof(int) + " bytes");
            Console.WriteLine("Base type of int is: " + a.GetType());
            Console.WriteLine("uint min value is: " + uint.MinValue);//0
            Console.WriteLine("uint max value is: " + uint.MaxValue);//4294967295

        }
    }
}
