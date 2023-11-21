
namespace AlgoritmosOrdenacao.algoritmos
{
    public class Insertion
    {
        public void InsertionSort(int[] array)
        {
            int n = array.Length;
            int i, j, atual;

            for (i = 1; i < n; i++)
            {
                atual = array[i];
                j = i;

                while ((j > 0) && (array[j - 1] > atual))
                {
                    array[j] = array[j - 1];
                    j = j - 1;
                }

                array[j] = atual;
            }

        }
    }
}
