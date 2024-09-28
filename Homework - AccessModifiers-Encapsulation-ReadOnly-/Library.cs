using static System.Reflection.Metadata.BlobBuilder;

namespace Homework___AccessModifiers_Encapsulation_ReadOnly_
{
    //Step 3: Istənilən sayda kitab əlavə etmək
    //üçün List-dən istifadə olunur
    public class Library
    {
        public List<Book> bookss = new List<Book> ();

        //Kitab əlavə edilməsi methodu
        public void AddBook(Book book)
        {
            if (bookss.Find(b => b.Name == book.Name) == null)
            {
                bookss.Add(book);
            }
            else
            {
                Console.WriteLine("Kitabxanada bu kitab movcutdur");
            }
        }

        //Kitab silinməsi methodu
        public void RemoveBookByName(string name)
        {
            bookss.RemoveAll(b => b.Name == name); 
        }

        //Ada görə kitab tapmaq
        public Book FindBookByName(string name)
        {
            return bookss.Find(b => b.Name == name); 
        }

        //Bütün kitabları göstər
        public List<Book> GetAllBooks()
        {
            return bookss; 
        }
    }
    
}
