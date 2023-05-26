using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Group12405_Console_Lab9.Lab9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);

            //b2.Show();
            //Book.SetPrice(12);
            //b2.Show();
            //Item item1 = new Item();
            //item1.Show();
            //b2.TakeItem();
            //b2.Show();
            //mag1.Show();
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Show();
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Show();
            
            mag1.TakeItem();
            mag1.Show();
            mag1.IfSubs = true;
            mag1.Subs();



            Console.ReadLine();


        }

    }
}
