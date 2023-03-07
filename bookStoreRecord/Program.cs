using System;
using System.Security.AccessControl;
using System.Xml.Schema;

namespace Demo
{
    class Program
    {
        public class Book
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public double Price { get; set; }
            public Book()
            {
                ID = 0;
                Title = string.Empty;
                Author = string.Empty;
                Price = 0;
            }
            public Book(int id, string title, string author, double price)
            {
                ID = id; Title = title; Author = author; Price = price;
               
            }
            public string info()
            {
                return Title + " by " + Author;
            }
            public string pay()
            {
                return "$" + Price;
            }
        }
        public static void Main()
        {
        Book book = new Book();
        book.ID= 1;
        book.Title = "1984";
        book.Author = "George Orwell";
        book.Price = 19.24;
        Console.WriteLine(book.info());
        Console.WriteLine(book.pay());

        Book book2 = new Book();
        book2.ID = 2;
        book2.Title = "Animal Farm";
        book2.Author = "George Orwell";
        book2.Price = 16.74;
        Console.WriteLine(book2.info());
        Console.WriteLine(book2.pay());

        Book book3 = new Book();
        book3.ID = 3;
        book3.Title = "Essays";
        book3.Author = "George Orwell";
        book3.Price = 11.99;
        Console.WriteLine(book3.info());
        Console.WriteLine(book3.pay());
        Console.ReadLine();
        
        }
    }
}