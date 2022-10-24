using Console_Library;
using CSC160;
using System;

namespace Foundation
{
    class Program
    {
        static void Main(string[] args)
        {
            CLibraryClass a = new CLibraryClass();
            int b = a.GetConsoleInt("balls", 1, 10);
            Console.WriteLine(b);
        }
    }
}