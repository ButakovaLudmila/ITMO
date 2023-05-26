using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Group12405_Console_Lab9.Lab9_1
{
    internal class Book: Item
    {
        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private static double price = 9; //Стоимость аренды
        private bool returnSrok;
        public Book() //Конструктор по умолчанию
        { 
        }
        static Book() //статический конструктор
        {
            price = 10;
        }
        public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return() // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }



        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        new public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4} p.в сутки", author, title, year, pages, Book.price);
            base.Show();
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }



    }
}
