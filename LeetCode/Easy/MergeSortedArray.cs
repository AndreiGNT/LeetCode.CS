using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int idxToFill = m + n - 1;
            int idxNums1 = m - 1;
            int idxNums2 = n - 1;

            if (m == 0)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums1[i] = nums2[i];
                }
            }

            while (idxNums2 >= 0)
            {
                if (idxNums1 < 0 || nums2[idxNums2] > nums1[idxNums1])
                {
                    nums1[idxToFill] = nums2[idxNums2];
                    idxNums2--;
                }
                else
                {
                    nums1[idxToFill] = nums1[idxNums1];
                    idxNums1--;
                }
                idxToFill--;
            }
        }


        public void MergeSolutionOne(int[] nums1, int m, int[] nums2, int n)
        {
            int[] tempNums = new int[n + m];
            int i = 0;
            int j = 0;

            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    tempNums[i + j] = nums1[i];
                    i++;
                }
                else
                {
                    tempNums[i + j] = nums2[j];
                    j++;
                }
            }

            if (i < m)
            {
                for (int idx = i + j; idx < tempNums.Length; idx++)
                {
                    tempNums[idx] = nums1[i];
                    i++;
                }
            }
            else if (j < n)
            {
                for (int idx = i + j; idx < tempNums.Length; idx++)
                {
                    tempNums[idx] = nums2[j];
                    j++;
                }
            }

            for (int jdx = 0; jdx < nums1.Length; jdx++)
            {
                nums1[jdx] = tempNums[jdx];
            }
        }

        public void MergeTest()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;
            Merge(nums1, m, nums2, n);
            Console.Write("Result: ");
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.Write(nums1[i] + " ");
            }
            Console.WriteLine();

            int[] nums11 = [1, 2, 3, 8, 9, 12, 0, 0, 0];
            int m1 = 6;
            int[] nums21 = [2, 5, 6];
            int n1 = 3;
            Merge(nums11, m1, nums21, n1);
            Console.Write("Result: ");
            for (int i = 0; i < nums11.Length; i++)
            {
                Console.Write(nums11[i] + " ");
            }
            Console.WriteLine();

            int[] nums12 = [0];
            int m2 = 0;
            int[] nums22 = [2];
            int n2 = 1;
            Merge(nums12, m2, nums22, n2);
            Console.Write("Result: ");
            for (int i = 0; i < nums12.Length; i++)
            {
                Console.Write(nums12[i] + " ");
            }
        }
    }
}
