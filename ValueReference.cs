using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC160
{
    internal class ValueReference
    {
        public static void Engage()
        {
            int v1 = 2;
            int v2 = v1;
            v1 = 5;
            Console.WriteLine(v2);

            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = array1;

            Console.WriteLine(String.Join(", ", array1));
            Console.WriteLine(String.Join(", ", array2));

            Point p1 = new Point(12, 2);
            Point p2 = p1;

            p1.x = 200;
            p1.Write();
            p2.Write();
        }

        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Write()
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
        }
    }
}
