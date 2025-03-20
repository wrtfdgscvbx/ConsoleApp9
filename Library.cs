using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        private List<T> _mediaList = new List<T>(); // Список медиа
        private Dictionary<string, T> _mediaDictionary = new Dictionary<string, T>(); // Словарь для быстрого поиска

        public void Add(T item)
        {
            if (_mediaDictionary.ContainsKey(item.Title))
            {
                throw new InvalidOperationException($"Медиа с названием '{item.Title}' уже существует.");
            }
            _mediaList.Add(item);
            _mediaDictionary[item.Title] = item;
        }

        public bool Remove(string title)
        {
            if (!_mediaDictionary.ContainsKey(title))
            {
                throw new KeyNotFoundException($"Медиа с названием '{title}' не найдено.");
            }
            var item = _mediaDictionary[title];
            _mediaList.Remove(item);
            return _mediaDictionary.Remove(title);
        }

        public T FindByTitle(string title)
        {
            if (!_mediaDictionary.ContainsKey(title))
            {
                throw new KeyNotFoundException($"Медиа с названием '{title}' не найдено.");
            }
            return _mediaDictionary[title];
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            return _mediaList.Where(m => m.YearPublished == year);
        }

        public IEnumerable<T> GetAllAvailable()
        {
            return _mediaList.Where(m => m.IsAvailable);
        }

        public void PrintAll()
        {
            foreach (var item in _mediaList)
            {
                Console.WriteLine(item);
            }
        }

        // Метод для выдачи медиа
        public void CheckOut(string title)
        {
            var item = FindByTitle(title);
            if (!item.IsAvailable)
            {
                throw new InvalidOperationException($"Медиа с названием '{title}' уже выдано.");
            }
            item.IsAvailable = false;
        }

        // Метод для возврата медиа
        public void Return(string title)
        {
            var item = FindByTitle(title);
            if (item.IsAvailable)
            {
                throw new InvalidOperationException($"Медиа с названием '{title}' уже доступно.");
            }
            item.IsAvailable = true;
        }
    }
}