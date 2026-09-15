using System.Drawing;

namespace oop_1
{
    #region question 4
    /*4-Declare an enum Genre { Fiction, NonFiction, Science }.
    Add a Genre property to Book, assign it Genre.Science, and print it.*/
    public enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    public class Book
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
        Book book = new Book();
            book.Title = "Science book";
            book.Genre = Genre.Science;
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Genre: {book.Genre}");

        }
    }
}
