using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC160
{
    internal class Converting
    {
        public static void Run()
        {
            //convert small to big
            int num = 69;
            long bigschlong = num;

            //explicit
            //if a conversion cannot be made without risk of losing info, the compiler requires you preform an explicit/cast.
            //converting double to int cuts off the decimal.
            double d = 124;
            int i = (int)d;
            Console.WriteLine(i);
            //cannot covert int to string unless
            string suck = "9";
            int wow = 8;
            wow = int.Parse(suck);
            Console.WriteLine(wow);

            bool success = int.TryParse(suck, out wow);
            Console.WriteLine(success);
        }

        public static bool InNumeric(string strNum)
        {
            double tempDbl;
            return double.TryParse(strNum, out tempDbl);
        }
    }
}
