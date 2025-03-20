namespace LibraryManagementSystem
{
    public abstract class Media
    {
        public string Title { get; set; }
        public string Author { get; set; } 
        public int YearPublished { get; set; } 
        public bool IsAvailable { get; set; } = true; 

        public Media(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }

        public override string ToString()
        {
            return $"{Title} от {Author} ({YearPublished}) - {(IsAvailable ? "Доступно" : "Не доступно")}";
        }
    }
}