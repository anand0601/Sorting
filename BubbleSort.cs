using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public class BubbleSort : ISort
    {
        public int[] Execute()
        {
            int[] arry = new int[10]; //{ 5,3,6,2,7,8,10,1,4,9};
            Random randomNo = new Random();
            for (int index = 0; index < 10; index++)
            {
                arry[index] = randomNo.Next(1, 10);
            }

            int i = 0, j = 0, temp = 0;

            for (i = arry.Length - 1; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (arry[j] > arry[j + 1])
                    {
                        temp = arry[j + 1];
                        arry[j + 1] = arry[j];
                        arry[j] = temp;
                    }
                }
            }
            return arry;

        }
    }
}
