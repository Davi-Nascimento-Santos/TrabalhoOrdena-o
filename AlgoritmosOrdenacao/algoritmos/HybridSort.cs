using System;

public class HybridSort
{
    public void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }
    public static void Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(array, low, high);

            if (high - pivot > 12)
            {
                Sort(array, low, pivot - 1);
            }
            else
            {
                InsertionSort(array, low, pivot - 1);
            }

            Sort(array, pivot + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    private static void InsertionSort(int[] array, int low, int high)
    {
        for (int i = low + 1; i <= high; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
}
