using QuickSort.AdditionScripts;
using QuickSort;

internal class Program
{
    private const int CountOfElementsToCreate = 10;

    private static void Main(string[] args)
    {   
        Console.WriteLine("--- Start ---\n");

        Console.WriteLine($"--- Count of elements - {CountOfElementsToCreate}\n");

        var randomCollectionGenerator = new RandomCollectionGenerator();
        var randomList = (IList<float>)randomCollectionGenerator.GetRandomFloatPositiveList(CountOfElementsToCreate);

        foreach (var randomFloat in randomList)
            Console.WriteLine($"{randomFloat}\n");

        Console.WriteLine("--- Sorted: ---");

        var sortedList = randomList.QuickSort();

        foreach (var sortedElement in sortedList)
            Console.WriteLine($"{sortedElement}\n");

        Console.ReadLine();
    }
}