namespace BLOCKLAB
{

    internal class Program
    {
        // Определение перечисления внутри класса(хз тут или не тут но пока тут)
        //Тип перечисления(или тип перечисления) — это тип значения, определенный набором именованных констант
        //базового целочисленного числового типа.
        //Чтобы определить тип перечисления, используйте ключевое enum слово и укажите имена элементов перечисления:
        //https://bestprogrammer.ru/programmirovanie-i-razrabotka/spravochnik-po-tipam-perechislenij-v-yazike-c-polnoe-rukovodstvo
        
        public enum Frequency
        {
            Weekly,
            Monthly,
            Yearly
        }

        static void Main(string[] args)
        {
            // Создание объекта типа Magazine
            Magazine magazine = new Magazine();

            // преобразовать данные в текстовый вид с помощью метода ToShortString() и вывести данные
            Console.WriteLine("Данные журнала (краткая информация):");
            Console.WriteLine(magazine.ToShortString());
            Console.WriteLine();

            // Присвоение значений всем свойствам
            magazine.Title = "Технологии и Наука";
            magazine.Frequency = Frequency.Monthly;
            magazine.ReleaseDate = new DateTime(2025, 5, 28);
            magazine.Circulation = 1500;

            // Преобразование данных в текстовый вид с помощью метода ToShortString() и вывод данных
            Console.WriteLine("Данные журнала (после присвоения значений):");
            Console.WriteLine(magazine.ToShortString());
            Console.WriteLine();

            // Создание статей
            Article article1 = new Article(new Person("Иван", "Иванов"), "Будущее технологий", 4.5);
            Article article2 = new Article(new Person("Мария", "Петрова"), "Научные открытия", 4.8);

            // Добавление статей в журнал
            magazine.AddArticles(article1, article2);

            // Вывод данных объекта Magazine, используя метод ToFullString()
            Console.WriteLine("Данные журнала (полная информация):");
            Console.WriteLine(magazine.ToFullString());
            
            
            


            //неактуально 
            //Console.WriteLine("Hello, World!");
        }
    }
}
