using System;
using System.Windows;

// View

namespace MVP
{    
    public partial class MainWindow : Window
    {
        EventHandler myevent = null;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler myEvent
        {
            add { myevent += value; }
            remove { myevent -= value; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myevent.Invoke(sender, e);
        }
    }
}
