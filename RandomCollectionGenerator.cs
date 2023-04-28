
namespace QuickSort
{
    internal class RandomCollectionGenerator
    {
        private const int MaxValue = 100000;
        private static readonly Random Randomizer = new Random(TimeOnly.MaxValue.Second);


        public RandomCollectionGenerator() { }


        public IEnumerable<float> GetRandomFloatPositiveCollection(int count)
        {
            for (int i = 0; i < count; i++)
                yield return Randomizer.Next(MaxValue) * Randomizer.NextSingle();
        }
    }
}
