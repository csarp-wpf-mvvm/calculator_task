using MVVM.Calculator.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MVVM.Calculator.ViewModel
{
    /// <summary>
    /// Számológép nézetmodell típusa.
    /// </summary>
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
