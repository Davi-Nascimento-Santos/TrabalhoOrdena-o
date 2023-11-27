
namespace AlgoritmosOrdenacao.algoritmos
{
    public class Heap
    {
        public void HeapSort(int[] array)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(array, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                heapify(array, i, 0);
            }

        }

        private void heapify(int[] array, int n, int i)
        {
            int maior = i;
            int esquerda = 2 * i + 1;
            int direita = 2 * i + 2;

            if ((esquerda < n) && (array[esquerda] > array[maior]))
            {
                maior = esquerda;
            }

            if ((direita < n) && (array[direita] > array[maior]))
            {
                maior = direita;
            }

            if (maior != i)
            {
                int swap = array[i];
                array[i] = array[maior];
                array[maior] = swap;

                heapify(array, n, maior);
            }
        }
    }
}
