using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP
{
    public class Presenter
    {
        private Model model;
        private Program view;

        public Presenter()
        {
            this.model = new Model();
            //this.view = View;
            Program.TextAdd += Program_TextAdd;
        }

        private void Program_TextAdd(string s)
        {
            Console.WriteLine(model.Logic(s));
        }
    }
}