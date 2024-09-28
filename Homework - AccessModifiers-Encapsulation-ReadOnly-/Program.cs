namespace Homework___AccessModifiers_Encapsulation_ReadOnly_
{
    public class Program
    {
            static void Main()
            {
                Library library = new Library();
                int choice = -1;

                while (choice != 0)
                {
                    Console.WriteLine("1. Kitabi daxil edin");
                    Console.WriteLine("2. Kitabı sil");
                    Console.WriteLine("3. Bütün kitablara bax");
                    Console.WriteLine("4. Seçilmiş kitaba bax (ada göre)");
                    Console.WriteLine("5. Ada göre axtarış et");
                    Console.Write("Seçiminizi edin: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Book newBook = new Book();
                            Console.WriteLine("Kitabın adını daxil edin: ");
                            newBook.Name = Console.ReadLine();
                            Console.WriteLine("Kitabın qiymətini daxil edin: ");
                            newBook.Price = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Kitabın janrını daxil edin: ");
                            newBook.Genre = Console.ReadLine();
                            library.AddBook(newBook);
                            break;

                        case 2:
                            Console.WriteLine("Silinəcək kitabın adını daxil edin: ");
                            string removeBook = Console.ReadLine();
                            library.RemoveBookByName(removeBook);
                            break;

                        case 3:
                            foreach (var book in library.GetAllBooks())
                            {
                                Console.WriteLine($"Ad: {book.Name}, Qiymət: {book.Price}, Janr: {book.Genre}");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Kitabın adını daxil edin: ");
                            string showBooksLibrary = Console.ReadLine();
                            var showBook = library.FindBookByName(showBooksLibrary);
                            if (showBook != null)
                            {
                                Console.WriteLine($"Ad: {showBook.Name}, Qiymət: {showBook.Price}, Janr: {showBook.Genre}");
                            }
                            else
                            {
                                Console.WriteLine("Kitab tapılmadı.");
                            }
                            break;

                        case 5:
                            Console.Write("Axtarış dəyərini girin: ");
                            string searchBook = Console.ReadLine();
                            foreach (var book in library.GetAllBooks())
                            {
                                if (book.Name.Contains(searchBook))
                                {
                                    Console.WriteLine($"Ad: {book.Name}, Qiymət: {book.Price}, Janr: {book.Genre}");
                                }
                            }
                            break;

                            default:
                            Console.WriteLine("Reqemi düzgün daxil edin!!!");
                            break;
                    }
                }
            }
        }

    }

