using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Book: A tuple with elements for the title, author, and publication year of a book.

namespace N36_HT2.Models
{
    public class Book
    {
        static void Main()
        {
            var book = ("The Great Gatsby", "F. Scott Fitzgerald", 1925);
            
            // Accessing elements of the tuple
            string title = book.Item1;
            string author = book.Item2;
            int publicationYear = book.Item3;

            // Displaying the book information
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publication Year: " + publicationYear);
        }
    }
}
