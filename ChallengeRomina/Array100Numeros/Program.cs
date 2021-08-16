using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array100Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getArray()
            {
                var result = new int[100];
            
                for (int i = 0; i < 100; i++)
                {
                    result[i] = i;
                }
                return result;
            }

            int getPosition(int number)
            {
                var array = getArray();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == number)
                        return i;
                }
                return -1;
            }

            Console.WriteLine(getPosition(5));
        }
    }
}
