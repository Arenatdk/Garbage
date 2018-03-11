using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private EventHandler startEvent;
        private EventHandler resetEvent;
        private EventHandler stopEvent;

        public event EventHandler StartEvent
        {
            add { startEvent += value; }
            remove { startEvent -= value; }
        }
        public event EventHandler ResetEvent
        {
            add { resetEvent += value; }
            remove { resetEvent -= value; }
        }
        public event EventHandler StopEvent
        {
            add { stopEvent += value; }
            remove { stopEvent -= value; }
        }

        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startEvent.Invoke(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopEvent.Invoke(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           resetEvent.Invoke(sender, e);
        }
    }
}
