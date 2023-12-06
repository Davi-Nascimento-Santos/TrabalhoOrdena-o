using System;

public class HybridSort
{
    public long inversoes = 0;
    public long comparacoes = 0;
    public void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }
    public void Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivot = HoarePartition(array, low, high);

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

    private int HoarePartition(int[] array, int low, int high)
    {

        int pivot = array[(low + high) / 2];

        int i = low - 1;
        int j = high + 1;

        while (true)
        {
            do
            {
                i++;
                comparacoes++;
            } while (array[i] < pivot);

            do
            {
                j--;
                comparacoes++;

            } while (array[j] > pivot);

            if (i >= j)
            {
                return j;
            }

            inversoes++;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    private void InsertionSort(int[] array, int low, int high)
    {
        for (int i = low + 1; i <= high; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                inversoes++;
                comparacoes++;
                array[j + 1] = array[j];
                j--;
            }
            comparacoes++;
            array[j + 1] = key;
        }
    }

    public long getInversoes()
    {
        return inversoes;
    }

    public long getComparacoes()
    {
        return comparacoes;
    }
}
