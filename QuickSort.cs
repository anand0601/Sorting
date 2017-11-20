using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public class QuickSort : ISort
    {
        //int[] arry = new int[10] { 5, 3, 6, 2, 7, 8, 10, 1, 4, 9 };
        int[] arry = new int[8] { 2, 7, 1, 8, 6, 3, 5, 4 };
        public int[] Execute()
        {

            //Random randomNo = new Random();
            //for (int index = 0; index < 10; index++)
            //{
            //    arry[index] = randomNo.Next(1, 10);
            //}
            Sort(0, arry.Length - 1);
           
            return arry;
        }

        private void Sort(int possition,int pivot)
        {
            if (possition < pivot)
            {
                int i = possition - 1;
                int j = possition, temp;
                for (j = possition; j <= pivot; j++)
                {
                    if (arry[j] < arry[pivot])
                    {
                        i = i + 1;
                        temp = arry[j];
                        arry[j] = arry[i];
                        arry[i] = temp;

                    }
                }

                int pivateValue,mid = 0;
                pivateValue = arry[pivot];

                for (int a = pivot; a > i + 1; a--)
                {
                    arry[a] = arry[a - 1];
                }

                arry[i + 1] = pivateValue;
                mid = i + 1;

                Sort(0, mid);
                Sort(mid + 1, pivot);
            }

        }

        


    }
}
