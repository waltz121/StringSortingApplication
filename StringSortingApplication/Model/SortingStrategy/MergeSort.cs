using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortingApplication.Model.SortingStrategy
{
    public class MergeSort : ISortingStrategy
    {
        public string Name {
            get { return "MergeSort"; }
        }

        public string Execute(string str)
        {
           char[] ArrayStr = StringSortingService.ConvertToCharacterArray(str);
            int low = 0;
            int high = ArrayStr.Length - 1;

            MergeSortAlgo(ArrayStr, low , high);

            return StringSortingService.ConvertCharArrayToString(ArrayStr);
        }

        private void Merge(char[] arrayStr, int low, int middle, int high)
        {
            int i, j, k;

            int n1 = middle - low + 1;
            int n2 = high - middle;

            char[] LeftArray = new char[n1];
            char[] RightArray = new char[n2];

            for(i=0; i< n1; i++)
            {
                LeftArray[i] = arrayStr[low + i];
            }

            for(j = 0; j< n2; j++)
            {
                RightArray[j] = arrayStr[middle + 1 + j];
            }

            i = 0;
            j = 0;
            k = low;

            while(i< n1 && j < n2)
            {
                if(LeftArray[i] <= RightArray[j])
                {
                    arrayStr[k] = LeftArray[i];
                    i++;
                }
                else
                {
                    arrayStr[k] = RightArray[j];
                    j++;
                }
                k++;
            }
            
            while(i < n1)
            {
                arrayStr[k] = LeftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arrayStr[k] = RightArray[j];
                j++;
                k++;
            }
        }

        private void MergeSortAlgo(char[] arrayStr, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                MergeSortAlgo(arrayStr, low, middle);
                MergeSortAlgo(arrayStr, middle + 1, high);
                Merge(arrayStr, low, middle, high);
            }
        }
    }
}
