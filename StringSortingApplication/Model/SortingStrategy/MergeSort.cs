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
            return "This is Merge Sort Return Value";
        }
    }
}
