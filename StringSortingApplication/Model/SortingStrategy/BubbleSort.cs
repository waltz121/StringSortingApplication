using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortingApplication.Model.SortingStrategy
{
    public class BubbleSort : ISortingStrategy
    {
        public string Name {
            get { return "BubbleSort"; }
        }

        public string Execute(string str)
        {
            char[] ArrayStr = StringSortingService.ConvertToCharacterArray(str);

            char temp;
            for (int j = 0; j <= ArrayStr.Length-2; j++) {
                for(int i = 0; i <= ArrayStr.Length -2; i++)
                {
                    if(ArrayStr[i] > ArrayStr[i + 1])
                    {
                        temp = ArrayStr[i + 1];
                        ArrayStr[i + 1] = ArrayStr[i];
                        ArrayStr[i] = temp;
                    }
                }

            }

            return StringSortingService.ConvertCharArrayToString(ArrayStr);
        }

      
       
    }
}
