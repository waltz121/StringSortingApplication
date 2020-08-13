using StringSortingApplication.Model;
using StringSortingApplication.Model.SortingStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSortingApplication.Controller
{
    public class StringSortingController
    {
        StringSortingModel stringSortingModel;

        public StringSortingModel InitializeIndexModel() 
        {
            List<ISortingStrategy> sortingStrategies = new List<ISortingStrategy>()
            {
                 new BubbleSort(),
                 new MergeSort(),
                 new QuickSort()
            };
            stringSortingModel = new StringSortingModel("", "", sortingStrategies);
            return stringSortingModel;
        }

        public string SortString(ISortingStrategy Strategy, string InputText)
        {
            string TmpVar = Strategy.Execute(InputText);
            return TmpVar;
        }

    }
}
