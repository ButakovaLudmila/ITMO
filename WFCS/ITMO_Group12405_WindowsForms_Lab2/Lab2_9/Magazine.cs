using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO_Group12405_WindowsForms_Lab2.Lab2_9
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken): base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


        public override void Return()    // операция "вернуть"
        {
            taken = true;
        }

        // реализация интерфейса



        public void Subs()
        {
            Console.WriteLine("Подписка на журнал \"{0}\": {1}.", title, IfSubs);
        }


        public override string ToString()
        {
            if (IfSubs)
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
                "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
            else
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
            "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
        }
    }
}
