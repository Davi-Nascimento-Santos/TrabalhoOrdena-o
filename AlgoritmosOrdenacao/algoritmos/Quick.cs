namespace AlgoritmosOrdenacao.algoritmos
{
    public class Quick
    {
        public long inversoes = 0;
        public long comparacoes = 0;
        public void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                
                int pivotIndex = HoarePartition(array, low, high);

                
                QuickSort(array, low, pivotIndex);
                QuickSort(array, pivotIndex + 1, high);
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

                inversoes ++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
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
}
