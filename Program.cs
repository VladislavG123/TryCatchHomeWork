using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Division division = new Division();
            Console.WriteLine(division.Do(12, 12));
            Console.Read();

            SmartArray smartArray = new SmartArray();
            smartArray.Fill(20);
            int number = smartArray[100];
            Console.Read(); Console.Read();
        }
    }
}
