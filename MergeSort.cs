using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public class MergeSort : ISort
    {
        int[] arry = new int[10] { 5, 3, 6, 2, 7, 8, 10, 1, 4, 9 };
        int[] arryB = new int[10];
        public int[] Execute()
        {
            //int[] arry = new int[10] { 5,3,6,2,7,8,10,1,4,9};
            //Random randomNo = new Random();
            //for (int index = 0; index < 10; index++)
            //{
            //    arry[index] = randomNo.Next(1, 10);
            //}

            Sort(0, arry.Length - 1);



            return arry;
        }


        private void Sort(int low, int high)
        {
            int mid;

            if (low < high)
            {
                mid = (low + high) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merging(low, mid, high);
            }
        }

        private void Merging(int low, int mid, int high)
        {
            int l1 = low, l2 = mid + 1, i;

            for (i = low; l1 <= mid && l2 <= high; i++)
            {
                if (arry[l1] <= arry[l2])
                    arryB[i] = arry[l1++];
                else
                    arryB[i] = arry[l2++];
            }


            while (l1 <= mid)
                arryB[i++] = arry[l1++];

            while (l2 <= high)
                arryB[i++] = arry[l2++];



            for (int j = low; j <= high; j++)
                arry[j] = arryB[j];

        }
    }
}
