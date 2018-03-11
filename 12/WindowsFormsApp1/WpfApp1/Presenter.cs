using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp1
{
    public class Presenter
    {
        private Model model;
        private MainWindow view;

        public Presenter( MainWindow m)
        {
            this.model = new Model();
            this.view = m;
            view.MinusEvent += View_MinusEvent;
            view.PlusEvent += View_PlusEvent;
            view.DivideEvent += View_DivideEvent;
            view.MultiplyEvent += View_MultiplyEvent;       
        }

        private string View_MultiplyEvent(string s1, string s2)
        {
            return model.Multiply(s1, s2);
        }

        private string View_DivideEvent(string s1, string s2)
        {
            return model.Divide(s1, s2);
        }

        private string View_PlusEvent(string s1, string s2)
        {
            return model.Plus(s1, s2);
        }

        private string View_MinusEvent(string s1, string s2)
        {
            return model.Minus(s1, s2);
        }
    }
}