using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC160
{
    internal class Parameters
    {
        public static void DoIt()
        {
            int rf = 7;
            int[] ary = new int[] { 5, 6 };

            string strByVal = "Red";
            Test test = new Test();

            test.x = 1;
            int wumbo = 69;
            int[] ary1 = new int[9];
            ary.CopyTo(ary1, 0);

            ByValRefTest(ref rf, strByVal, ary, test, wumbo);
            //Console.WriteLine(rf);
            //Console.WriteLine(strByVal);
            Console.WriteLine(ary[0]);
        }

        public static void ByValRefTest(ref int xRef, string sVal, int[] ary, Test test, int intValue)
        {
            xRef = xRef * xRef;
            sVal = "funny";
            ary[0] = 10;
            test.x = 68;
            intValue = 9;
        }
    }

    

    public class Test
    {
        public int x;
    }
}
