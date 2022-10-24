using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation{
    internal class DataTypes{
        public static void Excecute()
        {
            short sht = 16;
            int i = 32;
            uint unt = 32; //unsigned int
            long peen = 64;
            float fock = 4.0f;
            decimal deep = 1;

            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine();

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine();

            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine();

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine();

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine();

            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine();

            char a = 'R';
            Console.WriteLine(a);
            Console.WriteLine(char.IsDigit(a));
            Console.WriteLine(char.IsLetter(a));

            string b = "Cheese";

        }
    }
}
