using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate string Mydelegate(string s1, string s2);

        private Mydelegate plusEvent;
        private Mydelegate minusEvent;
        private Mydelegate multiplyEvent;
        private Mydelegate divideEvent;
        #region Event prop
        public event Mydelegate PlusEvent
        {
            add { plusEvent += value; }
            remove { plusEvent -=value; }
        }

        public event Mydelegate MinusEvent
        {
            add { minusEvent += value; }
            remove { minusEvent -= value; }
        }

        public event Mydelegate MultiplyEvent
        {
            add { multiplyEvent += value; }
            remove { multiplyEvent -= value; }
        }

        public event Mydelegate DivideEvent
        {
            add { divideEvent += value; }
            remove { divideEvent -= value; }
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
           LResult.Content = plusEvent.Invoke(TBFirst.Text, TBLast.Text);
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            LResult.Content = divideEvent.Invoke(TBFirst.Text, TBLast.Text);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            LResult.Content = minusEvent.Invoke(TBFirst.Text, TBLast.Text);
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            LResult.Content = multiplyEvent.Invoke(TBFirst.Text, TBLast.Text);
        }
    }
}
