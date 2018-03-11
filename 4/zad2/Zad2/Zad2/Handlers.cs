using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();

    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт XML");
        }

        public override void Chenge()
        {
            Console.WriteLine("Изменен XML");
        }

        public override void Create()
        {
            Console.WriteLine("Создан XML");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранен XML");
        }
    }

    class TXTHandler : AbstractHandler
    {
        

        public override void Open()
        {
            Console.WriteLine("Открыт TXT");
        }

        public override void Chenge()
        {
            Console.WriteLine("Изменен TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Создан TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранен TXT");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт DOC");
        }

        public override void Chenge()
        {
            Console.WriteLine("Изменен DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Создан DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранен DOC");
        }
    }
}
