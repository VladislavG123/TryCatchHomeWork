using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHomeWork
{
    class Division
    {
        public double Do(double firstConstant, double secondCostant)
        {

            double resualt = 0;
            try
            {
                if (secondCostant == 0)
                {
                    throw new Exception("ArgumentException");
                }
                
                resualt = firstConstant / secondCostant;
            } 
            catch 
            {
                Console.WriteLine("ArgumentException");
                return 0;
                throw;
            }
            
            return resualt;
        }
    }
}
