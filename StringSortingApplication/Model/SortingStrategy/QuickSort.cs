using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortingApplication.Model.SortingStrategy
{
    public class QuickSort : ISortingStrategy
    {
        public string Name { 
            get { return "QuickSort"; } 
        }

        public string Execute(string str)
        {
            char[] ArrayStr = StringSortingService.ConvertToCharacterArray(str);
            int low = 0;
            int high = ArrayStr.Length-1;

            QuickSortAlgo(ArrayStr, low, high);

            return StringSortingService.ConvertCharArrayToString(ArrayStr);
        }

        private void QuickSortAlgo(char[] arrayStr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arrayStr, low, high);

                QuickSortAlgo(arrayStr, low, pi - 1);
                QuickSortAlgo(arrayStr, pi + 1, high);
            }
        }

        private int Partition(char[] arrayStr, int low, int high)
        {
            char Pivot = arrayStr[high];

            int i = (low - 1);
            for (int j = low; j< high; j++)
            {
                if(arrayStr[j] < Pivot)
                {
                    i++;

                    char temp = arrayStr[i];
                    arrayStr[i] = arrayStr[j];
                    arrayStr[j] = temp;
                }
            }

            char temp2 = arrayStr[i + 1];
            arrayStr[i + 1] = arrayStr[high];
            arrayStr[high] = temp2;

            return i + 1;
        }
    }
}
