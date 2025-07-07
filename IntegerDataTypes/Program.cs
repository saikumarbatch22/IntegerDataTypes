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
            short c = 25;
            Console.WriteLine($"Short: {c}");
            Console.WriteLine("value of a is: " + c);
            Console.WriteLine("Size of short is: " + sizeof(short) + " bytes");
            Console.WriteLine("Base type of short is: " + c.GetType());
            Console.WriteLine("short  mine value is" + short.MinValue);//-32768
            Console.WriteLine("short max value is" + short.MaxValue);//  32767
            Console.WriteLine("ushort min value is" + ushort.MinValue);// 0
            Console.WriteLine("ushort max value  is: " + ushort.MaxValue);//      

            int a = 214748364;
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine("int min value is: " + int.MinValue);
            Console.WriteLine("int max value is: " + int.MaxValue);
            Console.WriteLine("Size of int is: " + sizeof(int) + " bytes");
            Console.WriteLine("Base type of int is: " + a.GetType());
            Console.WriteLine("uint min value is: " + uint.MinValue);//0
            Console.WriteLine("uint max value is: " + uint.MaxValue);//4294967295

            long b = 50000;
            Console.WriteLine("value of b is" + b);
            Console.WriteLine("long min value is: " + long.MinValue);   
            Console.WriteLine("long max value is: " + long.MaxValue);
            Console.WriteLine("size of long is : " + sizeof(long) + " bytes");//8bytes
            Console.WriteLine("Base type of long is: " + b.GetType());
            Console.WriteLine("ulong min value is: " + ulong.MinValue);//0
            Console.WriteLine("ulong max value is: " + ulong.MaxValue);//18446744073709551615


        }
    }
}
