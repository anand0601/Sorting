using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public class InsertionSort : ISort
    {
        public int[] Execute()
        {
            int[] arry = new int[10];// { 5,3,6,2,7,8,10,1,4,9};
            Random randomNo = new Random();
            for (int index = 0; index < 10; index++)
            {
                arry[index] = randomNo.Next(1, 10);
            }

            int possition, i, j, swap = 0;

            for (i = 0; i < arry.Length - 1; i++)
            {
                possition = i;

                for (j = i + 1; j < arry.Length; j++)
                {
                    if (arry[possition] > arry[j])
                    {
                        swap = arry[j];
                        arry[j] = arry[possition];
                        arry[possition] = swap;
                    }
                }

            }

            return arry;

        }
    }
}
