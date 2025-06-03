using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLOCKLAB.Program;

namespace BLOCKLAB
{
    internal class Magazine
    {
        // Закрытые поля
        private string title;            // Название журнала
        private Frequency frequency;     // Периодичность выхода
        private DateTime releaseDate;    // Дата выхода
        private int circulation;         // Тираж
        private Article[] articles;      // Список статей


        // Конструктор с параметрами типа string, Frequency, DateTime, int для инициализации
        // соответствующих полей класса
        public Magazine(string title, Frequency frequency, DateTime releaseDate, int circulation)
        {
            this.title = title;
            this.frequency = frequency;
            this.releaseDate = releaseDate;
            this.circulation = circulation;
            this.articles = new Article[0]; // Инициализация пустого массива статей
        }

        // Конструктор без параметров с значениями по умолчанию
        public Magazine() : this("НазваниеЖурнала", Frequency.Monthly, DateTime.Now, 1000)
        {
        }

        // Свойства для доступа к полям
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Frequency Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public int Circulation
        {
            get { return circulation; }
            set { circulation = value; }
        }

        public Article[] Articles
        {
            get { return articles; }
        }

        // Свойство для вычисления среднего  рейтинга статей
        public double AverageRating
        {
            get
            {
                if (articles.Length == 0) return 0.0;

                double totalRating = 0.0;
                foreach (var article in articles)
                {
                    totalRating += article.Rating;
                }
                return totalRating / articles.Length;
            }
        }

        // Метод void AddArticles (params Article[]) для добавления статей
        public void AddArticles(params Article[] newArticles)
        {
            int currentLength = articles.Length;
            Array.Resize(ref articles, currentLength + newArticles.Length);
            Array.Copy(newArticles, 0, articles, currentLength, newArticles.Length);
        }

        // Метод string ToFullString() для формирования строки со значениями всех полей
        public string ToFullString()
        {
            string articlesList = string.Join(", ", articles);
            return $"Журнал: {title}, Периодичность: {frequency}, Дата выхода: {releaseDate.ToShortDateString()}, Тираж: {circulation}, Статьи: [{articlesList}]";
        }

        // Метод string ToShortString() для формирования строки без списка статей, но со средним рейтингом
        public string ToShortString()
        {
            return $"Журнал: {title}, Периодичность: {frequency}, Дата выхода: {releaseDate.ToShortDateString()}, Тираж: {circulation}, Средний рейтинг: {AverageRating}";
        }
    }
}
