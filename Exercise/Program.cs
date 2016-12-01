using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static double Checkout(string[] items, bool discount)
        {
            if (items.Length == 0)
                return 0.0;

            var applesCounter = items.Count(x => "apple".Equals(x, StringComparison.InvariantCultureIgnoreCase));
            var orangesCounter = items.Length - applesCounter;

            if(!discount)
                return (applesCounter * 0.65) + (orangesCounter * 0.45);

            applesCounter = applesCounter / 2;

            if(orangesCounter % 3 == 0)
            {
                var extras = orangesCounter / 3;
                orangesCounter = extras * 2;
            }

            return (applesCounter * 0.65) + (orangesCounter * 0.45);
        }
    }
}
