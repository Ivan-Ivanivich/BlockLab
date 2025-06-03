using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOCKLAB
{
    internal class Article
    {
       
        // Открытые свойства (три открытых автореализуемых свойства, доступных для чтения и записи)
        public Person Author { get; set; }  // Свойство для хранения данных автора статьи
        public string Title { get; set; }    // Свойство для названия статьи
        public double Rating { get; set; }   // Свойство для рейтинга статьи

        // Конструктор с параметрами
        public Article(Person author, string title, double rating)
        {
            Author = author;
            Title = title;
            Rating = rating;
        }

        // Конструктор без параметров с значениями по умолчанию (я не понимаю как испарвить ошибку и есть ли она тут)
        public Article() : this(author: new Person("ИмяПоУмолчанию", "ФамилияПоУмолчанию"), title: "НазваниеПоУмолчанию", rating: 0.0)
        {
        }

        // Метод для формирования строки со значениями всех свойств
        public string ToFullString()
        {
            return $"Автор: {Author}, Название: {Title}, Рейтинг: {Rating}";
        }

    }
}
