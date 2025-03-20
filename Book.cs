namespace LibraryManagementSystem
{
    public class Book : Media
    {
        public int PageCount { get; set; } // Количество страниц
        public string Genre { get; set; } // Жанр

        public Book(string title, string author, int yearPublished, int pageCount, string genre)
            : base(title, author, yearPublished)
        {
            PageCount = pageCount;
            Genre = genre;
        }

        public override string ToString()
        {
            return base.ToString() + $", Страниц: {PageCount}, Жанр: {Genre}";
        }
    }
}