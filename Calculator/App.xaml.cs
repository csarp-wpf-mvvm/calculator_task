using System.Windows;
using MVVM.Calculator.View;
using MVVM.Calculator.ViewModel;
using System.Windows.Controls;

namespace MVVM.Calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {            
            base.OnStartup(e);

            CalculatorWindow window = new CalculatorWindow(); // nézet létrehozása

            window.Show();            
        }
    }
}
