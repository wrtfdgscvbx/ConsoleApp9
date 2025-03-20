using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public interface IMediaManager<T> where T : Media
    {
        void Add(T item); // Добавить элемент
        bool Remove(string title); // Удалить элемент по названию
        T FindByTitle(string title); // Найти элемент по названию
        IEnumerable<T> FilterByYear(int year); // Фильтровать по году выпуска
        IEnumerable<T> GetAllAvailable(); // Получить все доступные элементы
    }
}