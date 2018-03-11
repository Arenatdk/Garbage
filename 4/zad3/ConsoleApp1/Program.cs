using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player();

            IPlayable ipl = pl;
            IRecodable irc = pl;

            ipl.Play();
            irc.Record();

            Console.WriteLine(ipl.GetHashCode());
            Console.WriteLine(irc.GetHashCode());
            Console.WriteLine(pl.GetHashCode());
            Console.ReadKey();
        }
    }
}
