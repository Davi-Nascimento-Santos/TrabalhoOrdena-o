using AlgoritmosOrdenacao.algoritmos;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Os paths abaixo são relativos ao meu computador, você deve alterá-los para que o programa funcione no seu
        string crescentePath = "C:\\Users\\samsung\\Documents\\CienciaComputaçao\\4 periodo\\PAA\\ordenacao\\TrabalhoOrdena-o\\numerosCrescente.csv";
        string decrescentePath = "C:\\Users\\samsung\\Documents\\CienciaComputaçao\\4 periodo\\PAA\\ordenacao\\TrabalhoOrdena-o\\numerosDecrescente.csv";
        string aleatorioPath = "C:\\Users\\samsung\\Documents\\CienciaComputaçao\\4 periodo\\PAA\\ordenacao\\TrabalhoOrdena-o\\numerosAleatorios.csv";
        string filePath = "";
        string outputPath = "C:\\Users\\samsung\\Documents\\CienciaComputaçao\\4 periodo\\PAA\\ordenacao\\TrabalhoOrdena-o\\AlgoritmosOrdenacao\\comparacoes.txt";
        bool encerrou = false;

        while (!encerrou)
        {
            Console.WriteLine("Digite quantas linhas você deseja ordenar: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do algoritmo que você deseja utilizar:\n>> 1 - BubbleSort\n>> 2 - HeapSort\n>> 3 - InsertionSort\n>> 4 - MergeSort\n>> 5 - QuickSort\n>> 6 - Hybrid");
            int algoritmo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do arquivo que você deseja ordenar:\n>> 1 - Crescente\n>> 2 - Aleatório\n>> 3 - Decrescente");
            int arquivo = int.Parse(Console.ReadLine());

            switch (arquivo)
            {
                case 1:
                    filePath = crescentePath;
                    break;
                case 2:
                    filePath = aleatorioPath;
                    break;
                case 3:
                    filePath = decrescentePath;
                    break;
                default:
                    Console.WriteLine("Você digitou uma opção inválida");
                    encerrou = true;
                    break;
            }

            string[] lines = File.ReadAllLines(filePath);
            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(lines[i]);
            }

            switch (algoritmo)
            {
                case 1:
                    Bubble bubble = new Bubble();
                    bubble.BubbleSort(numeros);
                    long comparacoesBubble = bubble.getComparacoes();
                    long inversoesBubble = bubble.getInversoes();
                    WriteToTxt(outputPath, algoritmo, inversoesBubble, comparacoesBubble, arquivo, n);
                    Console.WriteLine($"Arquivo ordenado: comparacoes {comparacoesBubble}, inversoes {inversoesBubble}");
                    break;
                case 2:
                    Heap heap = new Heap();
                    heap.HeapSort(numeros);
                    long comparacoesHeap = heap.getComparacoes();
                    long inversoesHeap = heap.getInversoes();
                    WriteToTxt(outputPath, algoritmo, inversoesHeap, comparacoesHeap, arquivo, n);
                    break;
                case 3:
                    Insertion insertion = new Insertion();
                    insertion.InsertionSort(numeros);
                    long comparacoesInsertion = insertion.getComparacoes();
                    long inversoesInsertion = insertion.getInversoes();
                    WriteToTxt(outputPath, algoritmo, inversoesInsertion, comparacoesInsertion, arquivo, n);
                    Console.WriteLine($"Arquivo ordenado: comparacoes {comparacoesInsertion}, inversoes {inversoesInsertion}");
                    break;
                case 4:
                    Merge merge = new Merge();
                    merge.MergeSort(numeros);
                    long inversoesMerge = merge.getInversoes();
                    long comparacoesMerge = merge.getComparacoes();
                    WriteToTxt(outputPath, algoritmo, inversoesMerge, comparacoesMerge, arquivo, n);
                    Console.WriteLine($"Arquivo ordenado: comparacoes {comparacoesMerge}, inversoes {inversoesMerge}");
                    break;
                case 5:
                    Quick quick = new Quick();
                    quick.QuickSort(numeros);
                    long inversoesQuick = quick.getInversoes();
                    long comparacoesQuick = quick.getComparacoes();
                    WriteToTxt(outputPath, algoritmo, inversoesQuick, comparacoesQuick, arquivo, n);
                    Console.WriteLine($"Arquivo ordenado: comparacoes {comparacoesQuick}, inversoes {inversoesQuick}");
                    break;
                case 6:
                    HybridSort hybrid = new HybridSort();
                    hybrid.Sort(numeros);
                    long inversoesHybrid = hybrid.getInversoes();
                    long comparacoesHybrid = hybrid.getComparacoes();
                    WriteToTxt(outputPath, algoritmo, inversoesHybrid, comparacoesHybrid, arquivo, n);
                    Console.WriteLine($"Arquivo ordenado: comparacoes {comparacoesHybrid}, inversoes {inversoesHybrid}");
                    break;
                default:
                    Console.WriteLine("Você digitou uma opção inválida");
                    encerrou = true;
                    break;
            }

            Console.WriteLine("Deseja encerrar o programa? (S - sim / N - não)");
            string encerrar = Console.ReadLine();
            if (encerrar.ToUpper() == "S")
            {
                encerrou = true;
            }
            else if (encerrar.ToUpper() == "N")
            {
                encerrou = false;
            }
            else
            {
                Console.WriteLine("Você digitou uma opção inválida");
                encerrou = true;
            }
        }


    }

    static void WriteToCsv(string filePath, string[] dataArray)
    {
        // Open the file for writing
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            // Write the array elements to the file, separated by commas
            sw.WriteLine(string.Join(",", dataArray));
        }
    }

    static void WriteToTxt(string filePath, int algoritmo, long inversoes,long comparacoes, int arquivo, int linhas)
    {
        string algoritmoS = "";
        string arquivoS = "";

        switch(algoritmo)
        {
            case 1:
                algoritmoS = "BubbleSort";
                break;
            case 2:
                algoritmoS = "HeapSort";
                break;
            case 3:
                algoritmoS = "InsertionSort";
                break;
            case 4:
                algoritmoS = "MergeSort";
                break;
            case 5:
                algoritmoS = "QuickSort";
                break;
            case 6:
                algoritmoS = "HybridSort";
                break;
        }

        switch(arquivo)
        {
            case 1:
                arquivoS = "Crescente";
                break;
            case 2:
                arquivoS = "Aleatorio";
                break;
            case 3:
                arquivoS = "Decrescente";
                break;
        }
        
        using (StreamWriter sw = new StreamWriter(filePath, true))
        {
            
            sw.WriteLine($"{algoritmoS}: comparações: {comparacoes}-> inversoes: {inversoes} -> arquivo: {arquivoS} -> linhas: {linhas}");
        }
    }


}


