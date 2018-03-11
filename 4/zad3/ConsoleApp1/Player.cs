using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Play()
        {
            Console.WriteLine("Пуск");
        }

        public void Record()
        {
            Console.WriteLine("Запись");
        }

        public void Stop()
        {
            Console.WriteLine("Стоп");
        }
    }
}
