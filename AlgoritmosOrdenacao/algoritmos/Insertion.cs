
namespace AlgoritmosOrdenacao.algoritmos
{
    public class Insertion
    {
        public long inversoes = 0;
        public long comparacoes = 0;
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
                    inversoes++;
                    comparacoes++;
                    array[j] = array[j - 1];
                    j = j - 1;
                }
                comparacoes++;
                array[j] = atual;
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
