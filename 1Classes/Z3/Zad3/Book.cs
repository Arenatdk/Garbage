using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Book
    {
        readonly Title t;
        readonly Author a;
        readonly Content c;

        public Book(string title,string author,string content)
        {
            this.t = new Title(title);
            this.a = new Author(author);
            this.c = new Content(content);
        }

        public void Show()
        {
            t.Show();
            a.Show();
            c.Show();
        }
    }
}
