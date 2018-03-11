using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Article
    {
        public string Name { get; set; }

        public string Magaz { get; private set; }
        public int Price { get; private set; }

        public Article(string name, string magaz, int price)
        {
            this.Name = name;
            this.Magaz = magaz;
            this.Price = price;
        }

        public string Info()
        {
            return "Name: " + Name + " Price: " + Price + " Magaz: " + Magaz;
        }
    }

    class Store
    {
        Article[] MyArticle = new Article[]
        {
            new Article("Shose","adik",1455),
            new Article("Shtani","adik",40),
            new Article("T-shose","adik",1500)
        };



        public string this[string nm]
        {
            get
            {
                foreach (Article item in MyArticle)
                {
                    if (item.Name == nm)
                    {
                        return item.Info();
                    }
                }
                return "Пусто";
            }
        }

        
        public int Length { get { return MyArticle.Length; } }

        public string this[int index]
        {
            get
            {
                return MyArticle[index].Info();
            }
        }
    }
}
