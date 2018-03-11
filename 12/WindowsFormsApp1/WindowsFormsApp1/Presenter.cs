using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Presenter
    {
        private Model model;
        private Form1 view;

        public Presenter(Form1 v)
        {
            this.model = new Model();
            this.view = v;
            view.StartEvent += View_StartEvent;
            view.ResetEvent += View_ResetEvent;
            view.StopEvent += View_StopEvent;
            view.timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            view.label1.Text = model.Tick();
        }

        private void View_StopEvent(object sender, EventArgs e)
        {
            view.timer1.Enabled = false;
        }

        private void View_ResetEvent(object sender, EventArgs e)
        {
            view.label1.Text = "--";
            model.Reset();
        }

        private void View_StartEvent(object sender, EventArgs e)
        {
            view.timer1.Enabled = true;
        }
    }
}