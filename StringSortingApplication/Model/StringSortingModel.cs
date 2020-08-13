using StringSortingApplication.Model.SortingStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortingApplication.Model
{
    public class StringSortingModel
    {
        public string InputText { get; set; }
        public string OutputText { get; set; }
        public List<ISortingStrategy> sortingStrategies { get; set; }

        public StringSortingModel(string inputText, string outputText, List<ISortingStrategy> sortingStrategies)
        {
            InputText = inputText;
            OutputText = outputText;
            this.sortingStrategies = sortingStrategies;
        }
    }
}
