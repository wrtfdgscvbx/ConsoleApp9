using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bookLibrary = new Library<Book>();

                bookLibrary.Add(new Book("1984", "Джордж Оруэлл", 1949, 328, "Антиутопия"));
                bookLibrary.Add(new Book("Убить пересмешника", "Харпер Ли", 1960, 281, "Роман"));
                bookLibrary.Add(new Book("Великий Гэтсби", "Фрэнсис Скотт Фицджеральд", 1925, 180, "Классика"));

                Console.WriteLine("Все книги:");
                bookLibrary.PrintAll();

                Console.WriteLine("\nКниги, опубликованные в 1960 году:");
                foreach (var book in bookLibrary.FilterByYear(1960))
                {
                    Console.WriteLine(book);
                }

                Console.WriteLine("\nВыдача книги '1984'...");
                bookLibrary.CheckOut("1984");

                Console.WriteLine("\nДоступные книги:");
                foreach (var book in bookLibrary.GetAllAvailable())
                {
                    Console.WriteLine(book);
                }

                Console.WriteLine("\nВозврат книги '1984'...");
                bookLibrary.Return("1984");

                Console.WriteLine("\nВсе книги после возврата:");
                bookLibrary.PrintAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}