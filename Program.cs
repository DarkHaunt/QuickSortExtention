using QuickSort;

internal class Program
{
    private const int CountOfElementsToCreate = 30;

    private static void Main(string[] args)
    {   
        Console.WriteLine("--- Start ---\n");
        Console.WriteLine($"--- Count of elements - {CountOfElementsToCreate}\n");

        var randomCollectionGenerator = new RandomCollectionGenerator();

        foreach (var randomFloat in randomCollectionGenerator.GetRandomFloatPositiveCollection(CountOfElementsToCreate))
            Console.WriteLine($"{randomFloat}\n");

        Console.ReadLine();
    }
}