using StringSortingApplication.Controller;
using StringSortingApplication.Model.SortingStrategy;
using System;
using System.Windows.Forms;

namespace StringSortingApplication
{
    public partial class Form1 : Form
    {
        StringSortingController stringSortingController;
        public Form1()
        {
            stringSortingController = new StringSortingController();
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            var Model = stringSortingController.InitializeIndexModel();
            InputTextbox.Text = Model.InputText;
            OutputValue.Text = Model.OutputText;

            var SortingBindingSource = new BindingSource();
            SortingBindingSource.DataSource = Model.sortingStrategies;
            SortingComboBox.DataSource = SortingBindingSource.DataSource;
            SortingComboBox.DisplayMember = "Name";
            SortingComboBox.ValueMember = "Name";
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            var StrategyName = SortingComboBox.SelectedItem as ISortingStrategy;
            var inputText = InputTextbox.Text;

            OutputValue.Text = stringSortingController.SortString(StrategyName, inputText);
        }
    }
}
