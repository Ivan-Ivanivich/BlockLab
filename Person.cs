using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOCKLAB
{
    internal class Person
    {
        // Закрытые поля
        private string firstName;
        private string lastName;
        private DateTime birthDate; 

        // Конструктор с параметрами
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        // Конструктор без параметров с значениями по умолчанию(что такое значение по умолячанию?xdlol)
        public Person() : this("ИмяПоУмолчанию", "ФамилияПоУмолчанию", new DateTime(2000, 1, 1))
        {
        }

        // Свойство для доступа к имени
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Свойство для доступа к фамилии
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Свойство для доступа к дате рождения
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        // Свойство для получения и изменения года рождения
        public int BirthYear
        {
            get { return birthDate.Year; }
            set
            {
                birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
            }
        }

        // Метод для формирования строки со значениями всех полей
        public string ToFullString()
        {
            return $"Имя: {firstName}, Фамилия: {lastName}, Дата рождения: {birthDate.ToShortDateString()}";
        }

        // Метод для получения строки с именем и фамилией
        public string ToShortString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
