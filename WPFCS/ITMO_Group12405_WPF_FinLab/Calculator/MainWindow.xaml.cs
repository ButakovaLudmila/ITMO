using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMO_Group12405_WPF_FinLab.Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        public MainWindow()
        {
            InitializeComponent();
        }

        //
        // Методы при нажатии цифровых кнопок.
        //
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(oneOut);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(twoOut);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(threeOut);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(fourOut);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(fiveOut);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(sixOut);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(sevenOut);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(eightOut);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(nineOut);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcNumber(zeroOut);
        }
        
        //
        // Методы при нажатии кнопок простых мат. опраций
        //
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Calculator.CalcOperation(Calculator.Operator.eAdd);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Calculator.CalcOperation(Calculator.Operator.eSubtract); 
        }

        private void btnMultiplicate_Click(object sender, RoutedEventArgs e)
        {
            Calculator.CalcOperation(Calculator.Operator.eMultiply); 
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            Calculator.CalcOperation(Calculator.Operator.eDivide); 
        }

        //
        // Методы при нажатии кнопок удаления и очистки
        //

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Calculator.CalcReset();
            txtDisplay.Text = "0";
        }

        //
        // Метод при нажатии кнопки вывода результата мат. операций
        //
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcEqual();
            Calculator.CalcReset();
        }

        //
        // Метод при нажатии кнопки точка
        //
        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcDecimal();
        }

        //
        // Метод при нажатии кнопки знак +/-
        //
        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = Calculator.CalcSign();
        }

        private void Menu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
