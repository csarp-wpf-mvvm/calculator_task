using System;

namespace MVVM.Calculator.Model
{
    /// <summary>
    /// Számológép eseményargumentum típusa.
    /// </summary>
    public class CalculatorEventArgs : EventArgs
    {
        private Double result;
        private String calculationString;

        /// <summary>
        /// Eredmény lekérdezése.
        /// </summary>
        public Double Result { get { return result; } }
        /// <summary>
        /// Számítás szöveges lekérdezése.
        /// </summary>
        public String CalculationString { get { return calculationString; } }

        /// <summary>
        /// Számológép eseményargumentum példányosítása.
        /// </summary>
        /// <param name="result">Eredmény.</param>
        /// <param name="calculationString">Számítás szövege.</param>
        public CalculatorEventArgs(Double result, String calculationString)
        {
            this.result = result;
            this.calculationString = calculationString;
        }
    }
}
