using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryHomeWork
{
    class SmartArray
    {
        List<int> _array = new List<int>();

        public void Fill(int lenght)
        {
            if (lenght <= 0)
                return;
            for (int i = 0; i < lenght; i++)
            {
                Random random = new Random();
                int number = random.Next();
                _array.Add(number);
            }
        }

        public int this[int index]
        {
            get
            {
                for (int i = 0; i < index; i++)
                {
                    try
                    {
                        if (i >= _array.Count)
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Завершение обработки массива!");
                        return _array[i - 1];
                    }
                    Console.WriteLine(_array[i]);
                }
                return _array[index];
            }
            set { _array[index] = value; }
        }
    }
}
