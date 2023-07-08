namespace Phils_Lending_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Library lib = new Library();
            lib.Add("Animal Book", "Yaman", "Ali", 200);
            lib.Add("Math Book", "Yaman", "Ali", 600);
            lib.Add("C# Book", "Yaman", "Ali", 500);
            lib.print();

            
            Console.WriteLine("The books library after borrowing: ");
            Book x = lib.Borrow("Animal Book");
            lib.print();
            Console.WriteLine("The books library after returning: ");
            lib.Return(x);
            lib.print();

            
            x = lib.Borrow("No Book");
            if (x is null)
                Console.WriteLine("Returned null.");
            x = lib.Borrow("Animal Book");
            Backpack<Book> items = new Backpack<Book>();
            items.Pack(x);

            
            if (x == items.Unpack(0))
                Console.WriteLine("Unpacked book.");

            // If we unpack item using index that does not exist, it will prompt the user and return null.
            items.Unpack(0);
        }
    }
}