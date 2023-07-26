using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SortAnArray
    {
        public int[] SortArray(int[] nums)
        {

            MergeSort(nums);

            return nums;
        }

        private static void MergeSort(int[] nums)
        {
            int len = nums.Length;
            if (len <= 1)
            {
                return;
            }

            int mid = (len) / 2;
            int[] arrOne = new int[mid];
            int[] arrTwo = new int[len - mid];

            int O = 0;
            int T = 0;

            for (; O < len; O++)
            {
                if(O < mid)
                {
                    arrOne[O] = nums[O];
                    continue;
                }

                arrTwo[T] = nums[O];
                T++;

            }

            MergeSort(arrOne);
            MergeSort(arrTwo);
            Merge(arrOne, arrTwo, nums);



        }

        private static void Merge(int[] arrOne, int[] arrTwo, int[] arr)
        {
            int arrOneSize = arr.Length / 2, arrTwoSize = arr.Length - arrOneSize;
            int i = 0, O = 0, T = 0;

            while (O < arrOneSize && T < arrTwoSize)
            {
                if (arrOne[O] < arrTwo[T])
                {
                    arr[i] = arrOne[O];
                    i++;
                    O++;
                    continue;
                }

                arr[i] = arrTwo[T]; i++; T++;
            }

            while (O < arrOneSize)
            {
                arr[i] = arrOne[O];
                i++; O++;
            }

            while(T < arrTwoSize)
            {
                arr[i] = arrTwo[T];
                i++; T++;
            }
        }
    }
}
