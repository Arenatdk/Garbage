using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Redactor
    {
        AbstractHandler handler;

        public Redactor(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);

            if (format == ".xml")
            {
                handler = new XMLHandler();
            }
            
            else if (format == ".doc")
            {
                handler = new DOCHandler();
            }
            else
            {
                handler = new TXTHandler();
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Save()
        {
            handler.Save();
        }

        public void Change()
        {
            handler.Chenge();
        }

        public void Create()
        {
            handler.Create();
        }

    }
}
