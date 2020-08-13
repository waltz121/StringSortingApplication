using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortingApplication.Model
{
    public static class StringSortingService
    {
        public static char[] ConvertToCharacterArray(string Str)
        {
            char[] tmp;

            tmp = Str.ToCharArray();

            return tmp;
        }

        public static string ConvertCharArrayToString(char[] charArray)
        {
            StringBuilder stringBuilder = new StringBuilder("");
           

           for(int i = 0; i < charArray.Length; i++)
            {
                stringBuilder.Insert(i, charArray[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
