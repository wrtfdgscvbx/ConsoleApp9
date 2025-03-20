namespace LibraryManagementSystem
{
    public class MusicAlbum : Media
    {
        public string Artist { get; set; } // Исполнитель
        public int TrackCount { get; set; } // Количество треков

        public MusicAlbum(string title, string author, int yearPublished, string artist, int trackCount)
            : base(title, author, yearPublished)
        {
            Artist = artist;
            TrackCount = trackCount;
        }

        public override string ToString()
        {
            return base.ToString() + $", Исполнитель: {Artist}, Треков: {TrackCount}";
        }
    }
}