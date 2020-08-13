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
            return "This is BubbleSort Return Value";
        }
    }
}
