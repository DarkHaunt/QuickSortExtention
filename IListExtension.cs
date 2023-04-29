using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal static class IListExtension
    {
        public static IList<T> QuickSort<T>(this IList<T> list) where T : IComparable
        {
            if (list.Count < 2)
                return list;

            var pivotIndex = list.Count / 2;

            var lessList = new List<T>(pivotIndex);
            var largerList = new List<T>(pivotIndex);
            var pivotEqualsList = new List<T>(1);

            foreach (var item in list)
            {
                var compareResult = item.CompareTo(list[pivotIndex]);

                if (compareResult < 0)
                {
                    lessList.Add(item);
                    continue;
                }

                if (compareResult > 0)
                {
                    largerList.Add(item);
                    continue;
                }


                pivotEqualsList.Add(item);
            }

            var sortedLessCollection = lessList.QuickSort();
            var sortedLargerCollection = largerList.QuickSort();
            var sortedCollection = sortedLessCollection.Concat(pivotEqualsList).Concat(sortedLargerCollection);

            var sortedList = new List<T>(list.Count);

            foreach (var item in sortedCollection)
                sortedList.Add(item);

            return sortedList;
        }
    }
}
