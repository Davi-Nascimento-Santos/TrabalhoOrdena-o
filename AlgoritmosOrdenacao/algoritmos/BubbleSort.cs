
namespace AlgoritmosOrdenacao.algoritmos
{
    public class Bubble
    {
        public long inversoes = 0;
        public long comparacoes = 0;
        public void BubbleSort(int[] array)
        {
            int n = array.Length;
            int k = n;
            int temp;
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    comparacoes++;
                    if (array[j - 1] > array[j])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        inversoes++;
                    }
                }
                k--;
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
