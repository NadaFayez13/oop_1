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
            //Book book = new Book();
            //    book.Title = "Science book";
            //    book.Genre = Genre.Science;
            //    Console.WriteLine($"Title: {book.Title}");
            //    Console.WriteLine($"Genre: {book.Genre}");

            #region question 5
            /*Using the Genre enum above, print the underlying int value Genre.Fiction,
            Genre.NonFiction, and Genre.Science by casting each to int.*/
            int fictionValue = (int)Genre.Fiction;
            int nonFictionValue = (int)Genre.NonFiction;
            int scienceValue = (int)Genre.Science;

            Console.WriteLine($"Genre.Fiction: {fictionValue}");
            Console.WriteLine($"Genre.NonFiction: {nonFictionValue}");
            Console.WriteLine($"Genre.Science: {scienceValue}");

            #endregion
        }
    }
}
