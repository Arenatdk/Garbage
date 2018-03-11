using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker dw;
            while (true)
            {
                Console.WriteLine("Номер ключа ");
                string key = Console.ReadLine();

                if (key == "pro")
                {
                    dw = new ProDocumentWorker();
                }
                else if (key == "exp")
                {
                    dw = new ExpertDocumentWorker();
                }
                else
                {
                     dw = new DocumentWorker();
                }
                    //DocumentWorker dw = new ExpertDocumentWorker();
                    dw.OpenDocument();
                dw.EditDocument();
                dw.SaveDocument();


            }


            Console.ReadKey();
        }
    }


}
