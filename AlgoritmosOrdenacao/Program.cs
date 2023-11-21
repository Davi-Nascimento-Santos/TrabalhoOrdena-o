using AlgoritmosOrdenacao.algoritmos;

string filePath = "C:\\Users\\samsung\\Documents\\CienciaComputaçao\\4 periodo\\PAA\\ordenacao\\TrabalhoOrdena-o\\numerosAleatorios.csv";
bool encerrou = false;

while (!encerrou)
{
    Console.WriteLine("Digite quantas linhas você deseja ordenar: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o algoritmo que você deseja utilizar: 1 - BubbleSort\n2 - HeapSort\n3 - InsertionSort\n4 - MergeSort\n5 - QuickSort ");
    int algoritmo = int.Parse(Console.ReadLine());

    string[] lines = File.ReadAllLines(filePath);
    int[] numeros = new int[n];

    for (int i = 0; i < n; i++)
    {
        numeros[i] = int.Parse(lines[i]);
    }

    switch(algoritmo)
    {
        case 1:
            Bubble bubble = new Bubble();
            bubble.BubbleSort(numeros);
            break;
        case 2:
            Heap heap = new Heap();
            heap.HeapSort(numeros);
            break;
        case 3:
            Insertion insertion = new Insertion();
            insertion.InsertionSort(numeros);
            break;
        case 4:
            Merge merge = new Merge();
            merge.MergeSort(numeros);
            break;
        case 5: 
            Quick quick = new Quick();
            quick.QuickSort(numeros);
            break;
        default:
            Console.WriteLine("Algoritmo inválido");
            break;
    }

    Console.WriteLine("Deseja encerrar a execução? 1 - Sim, 2 - Não");
    int encerrar = int.Parse(Console.ReadLine());
    if (encerrar == 1)
    {
        encerrou = true;
    }
    else if (encerrar == 2)
    {
        encerrou = false;
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}


