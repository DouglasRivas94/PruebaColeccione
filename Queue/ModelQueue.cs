using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class ModelQueue
    {
        private static int number = 1;
        Queue<int> position = new Queue<int>();

        public static string GetPosition()
        {
            string na;
            na = number.ToString("D4");
            return na;
        }
    }
}
