using System.Windows;

using MVVM.Calculator.ViewModel;

namespace MVVM.Calculator.View
{
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel(); // nézetmodell létrehozása            
            InitializeComponent();
            this.DataContext = viewModel;     
        }

        private void ViewModel_MouseClickCommandButton(object sender, System.EventArgs e)
        {

        }
    }
}
