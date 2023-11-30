namespace AlgoritmosOrdenacao.algoritmos
{
    public class Quick
    {
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partition the array, and get the index of the pivot element
                int pivotIndex = HoarePartition(array, low, high);

                // Recursively sort the subarrays
                QuickSort(array, low, pivotIndex);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        static int HoarePartition(int[] array, int low, int high)
        {
            
            int pivot = array[(low + high) / 2];

            int i = low - 1;
            int j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (array[i] < pivot);

                do
                {
                    j--;
                } while (array[j] > pivot);

                if (i >= j)
                {
                    return j; 
                }

              
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

    }
}
