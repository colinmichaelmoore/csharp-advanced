using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section2_5
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
            
        }

        public T this[int index]
        {
            get {throw new NotImplementedException();}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book {Isbn = "1111", Title = "Advanced C#"};

//            var numbers = new List();
//            numbers.Add(10);
//
//            var books = new BookList();
//            books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            //var books = new GenericList<book>();
            //books.Add(new Book());

        }
    }
}
