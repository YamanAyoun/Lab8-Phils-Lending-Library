using Phils_Lending_Library;

namespace TestLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            Library lib1 = new Library();
            lib1.Add("Book1", "Yaman", "Ali", 100);
            lib1.Add("Book2", "Yaman", "Ali", 100);
            lib1.Add("Book3", "Yaman", "Ali", 100);
            
            Assert.Equal(3, lib1.Count);
            Book book = lib1.Borrow("Test Book");
            
        }

        [Fact]
        public void BorrowTest()
        {
            Library lib2 = new Library();
            lib2.Add("Book1", "Yaman", "Ali", 100);
            lib2.Add("Book2", "Yaman", "Ali", 100);
            Book book = lib2.Borrow("Book1");
            Assert.Equal(1, lib2.Count);
        }

        [Fact]
        public void BorrowMissingTest()
        {
            Library lib3 = new Library();
            lib3.Add("Book1", "Yaman", "Ali", 100);
            lib3.Add("Book2", "Yaman", "Ali", 100);
            Book book = lib3.Borrow("Book10");
            Assert.Null(book);
        }

        [Fact]
        public void ReturnBookTest()
        {
            Library lib4 = new Library();
            lib4.Add("Book1", "Yaman", "Ali", 100);
            lib4.Add("Book2", "Yaman", "Ali", 100);
            Book book = lib4.Borrow("Book1");
            
            lib4.Return(book);
            
            Assert.Equal(2, lib4.Count);
        }

        [Fact]
        public void PackUnpackTest()
        {
            Library lib5 = new Library();
            lib5.Add("Book1", "Yaman", "Ali", 100);
            lib5.Add("Book2", "Yaman", "Ali", 100);
            Book book = lib5.Borrow("Book2");
            Backpack<string> items = new Backpack<string>();
            items.Pack(book.Title);
            string title = items.Unpack(0);
            Assert.Equal(title, book.Title);
        }
    }
}