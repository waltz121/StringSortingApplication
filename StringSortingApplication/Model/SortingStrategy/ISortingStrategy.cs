using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortingApplication.Model.SortingStrategy
{
    public interface ISortingStrategy
    {
        string Name { get; }
        string Execute(string str);
    }
}
