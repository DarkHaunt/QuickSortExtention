
namespace QuickSort.AdditionScripts
{
    internal class RandomCollectionGenerator
    {
        private const int MaxValue = 100;
        private static readonly Random Randomizer = new Random(TimeOnly.MaxValue.Second);


        public RandomCollectionGenerator() { }


        public IList<float> GetRandomFloatPositiveList(int count)
        {
            var list = new List<float>(count);

            for (int i = 0; i < count; i++)
                list.Add(Randomizer.Next(MaxValue) * Randomizer.NextSingle());

            return list;
        }
    }
}
