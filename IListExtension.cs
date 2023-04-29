using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal static class IListExtension
    {
        public static void QuickSort<T>(this IList<T> list) where T : IComparable
        {
            if (list.Count < 2)
                return;

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

            lessList.QuickSort();
            largerList.QuickSort();

            var currentIndex = 0;

            for (; currentIndex < lessList.Count; currentIndex++)
                list[currentIndex] = lessList[currentIndex];      

            for (int i = 0; i < pivotEqualsList.Count; i++, currentIndex++)
                list[currentIndex] = pivotEqualsList[i];               
            
            for (int i = 0; i < largerList.Count; i++, currentIndex++)
                list[currentIndex] = largerList[i];
        }
    }
}
