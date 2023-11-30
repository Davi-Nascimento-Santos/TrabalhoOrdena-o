using AlgoritmosOrdenacao.algoritmos;

class Program 
{
    static void Main(string[] args)
    {
        // Os paths abaixo são relativos ao meu computador, você deve alterá-los para que o programa funcione no seu
        string filePath = "C:\\Users\\samsung\\Documents\\CienciaComputaçao\\4 periodo\\PAA\\ordenacao\\TrabalhoOrdena-o\\numerosAleatorios.csv";
        string outputPath = "C:\\Users\\samsung\\Documents\\CienciaComputaçao\\4 periodo\\PAA\\ordenacao\\TrabalhoOrdena-o\\numerosOrdenados.csv";
        bool encerrou = false;

        while (!encerrou)
        {
            Console.WriteLine("Digite quantas linhas você deseja ordenar: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do algoritmo que você deseja utilizar:\n>> 1 - BubbleSort\n>> 2 - HeapSort\n>> 3 - InsertionSort\n>> 4 - MergeSort\n>> 5 - QuickSort");
            int algoritmo = int.Parse(Console.ReadLine());

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
                    WriteToCsv(outputPath, numeros.Select(x => x.ToString()).ToArray());
                    Console.WriteLine("Arquivo ordenado com sucesso! Veja o arquivo 'numerosOrdenados.csv'");
                    int inversoesBubble = bubble.getInversoes();
                    Console.WriteLine("Número de inversões: " + inversoesBubble);
                    break;
                case 2:
                    Heap heap = new Heap();
                    heap.HeapSort(numeros);
                    WriteToCsv(outputPath, numeros.Select(x => x.ToString()).ToArray());
                    Console.WriteLine("Arquivo ordenado com sucesso! Veja o arquivo 'numerosOrdenados.csv'");
                    int inversoesHeap = heap.getInversoes();
                    Console.WriteLine("Número de inversões: " + inversoesHeap);
                    break;
                case 3:
                    Insertion insertion = new Insertion();
                    insertion.InsertionSort(numeros);
                    WriteToCsv(outputPath, numeros.Select(x => x.ToString()).ToArray());
                    Console.WriteLine("Arquivo ordenado com sucesso! Veja o arquivo 'numerosOrdenados.csv'");
                    int inversoesInsertion = insertion.getInversoes();
                    Console.WriteLine("Número de inversões: " + inversoesInsertion);
                    break;
                case 4:
                    Merge merge = new Merge();
                    merge.MergeSort(numeros);
                    WriteToCsv(outputPath, numeros.Select(x => x.ToString()).ToArray());
                    Console.WriteLine("Arquivo ordenado com sucesso! Veja o arquivo 'numerosOrdenados.csv'");
                    int inversoesMerge = merge.getInversoes();
                    Console.WriteLine("Número de inversões: " + inversoesMerge);
                    break;
                case 5:
                    Quick quick = new Quick();
                    quick.QuickSort(numeros);
                    WriteToCsv(outputPath, numeros.Select(x => x.ToString()).ToArray());
                    Console.WriteLine("Arquivo ordenado com sucesso! Veja o arquivo 'numerosOrdenados.csv'");
                    int inversoesQuick = quick.getInversoes();
                    Console.WriteLine("Número de inversões: " + inversoesQuick);
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
            } else if (encerrar.ToUpper() == "N")
            {
                encerrou = false;
            } else
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


}



