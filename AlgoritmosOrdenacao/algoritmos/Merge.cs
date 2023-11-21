﻿
namespace AlgoritmosOrdenacao.algoritmos
{
    public class Merge
    {
        public int[] MergeSort(int[] array)
        {
            int[] temp = new int[array.Length];
            MergeSort(array, temp, 0, array.Length - 1);
            return array;
        }

        private void MergeSort(int[] array, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                MergeSort(array, temp, left, center);
                MergeSort(array, temp, center + 1, right);
                MergeArray(array, temp, left, center + 1, right);
            }
        }

        private void MergeArray(int[] array, int[] temp, int left, int right, int rightEnd)
        {
            int leftEnd = right - 1;
            int k = left;
            int num = rightEnd - left + 1;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left] <= array[right])
                {
                    temp[k++] = array[left++];
                }
                else
                {
                    temp[k++] = array[right++];
                }
            }

            while (left <= leftEnd)
            {
                temp[k++] = array[left++];
            }

            while (right <= rightEnd)
            {
                temp[k++] = array[right++];
            }

            for (int i = 0; i < num; i++, rightEnd--)
            {
                array[rightEnd] = temp[rightEnd];
            }
        }       
    }
}
