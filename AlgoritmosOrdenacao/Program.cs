using AlgoritmosOrdenacao.algoritmos;

int[] vetor = { 12, 11, 13, 5, 6, 7 };

Bubble bubble = new Bubble();
int[] vetorOrdenado = bubble.BubbleSort(vetor);

foreach (int item in vetorOrdenado)
{
    Console.Write(item + " ");
}
