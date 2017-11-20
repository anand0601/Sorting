using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public class SelectionSort : ISort
    {
        public int[] Execute()
        {
            int[] arry = new int[10];// { 5,3,6,2,7,8,10,1,4,9};
            Random randomNo = new Random();
            for (int index = 0; index < 10; index++)
            {
                arry[index] = randomNo.Next(1, 10);
            }

            int temp = 0, i = 0,j= 0,min =0 ;


            for (i = 0; i < arry.Length -1; i++)
            {
                min = i;

                for (j = i + 1; j < arry.Length; j++)
                {
                    if (arry[min] > arry[j])
                    {
                        min = j;
                    }
                }

                temp = arry[min];
                arry[min] = arry[i];
                arry[i] = temp;
               
            }
            return arry;

        }
    }
}
