using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phils_Lending_Library
{
    public class Library : ILibrary
    {

        private Dictionary<string, Book> libraryBook;

        public Library() {


            libraryBook = new Dictionary<string, Book>();
        }    
        public int Count
        {
            get
            {
                return libraryBook.Count;
            }
        }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book myBook = new Book();
            try
            {
                myBook.Title = title;
                myBook.authorFirstname = firstName;
                myBook.authorLastname = lastName;
                myBook.numberOfpages = numberOfPages;
                libraryBook.Add(myBook.Title, myBook);
            }
            catch (Exception e)
            {
                myBook.Title += $"{libraryBook.Count}";
                Console.WriteLine(e.Message);
                Console.WriteLine($"New title has been added with a title of {myBook.Title}");
                libraryBook.Add(myBook.Title, myBook);
            }
        }

        public Book Borrow(string title)
        {
            
            if (libraryBook.ContainsKey(title))
            {
                Book book = libraryBook[title];
                libraryBook.Remove(title);
                return book;
            }
            else
            {
                return null;
            }
        }

        public void print()
        {
            Dictionary<string, Book>.ValueCollection values = libraryBook.Values;
            Console.WriteLine(" ");
            foreach (Book element in values)
            {

                Console.WriteLine($"Title: {element.Title},First Name: {element.authorFirstname},Last Name: {element.authorLastname},Number Of Pages: {element.numberOfpages}.");
            }
            Console.WriteLine("----");
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Return(Book book)
        {
            libraryBook.Add(book.Title, book);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
