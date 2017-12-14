using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is suppose to be a verry long blog post blah blah blah...";
            var shortenPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() {1, 5, 3, 10};
            var max = numbers.Max();
            Console.WriteLine(max);

            Console.WriteLine(shortenPost);
        }
    }
}
