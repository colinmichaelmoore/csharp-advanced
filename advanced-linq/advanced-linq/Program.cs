using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
/*
            //LINQ extension methods
            books.Single();
            books.SingleOrDefault();

            books.First();
            books.FirstOrDefault();

            books.Last();
            books.LastOrDefault();

            books.Min();
            books.Max();
            books.Count();
            books.Sum();
            books.Average(b => b.Price);

            books.Skip(5).Take(3);*/

//            var cheapBooks = new List<Book>();
//            foreach (var book in books)
//            {
//                if (book.Price < 10)
//                    cheapBooks.Add(book);
//            }

            //LINQ query operators

            /*var cheaperBooks = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            //Linq extension methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            //books.OrderBy(b => b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }*/
        }
    }
}
