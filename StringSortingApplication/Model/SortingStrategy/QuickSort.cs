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
            return "This is QuickSort Return Value";
        }
    }
}
