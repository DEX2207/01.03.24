using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1._03._24
{
    class Abiturient:Person
    {
        private string faculty;

        public Abiturient(string name, string surname, DateTime birthday,string faculty): base(name,surname,birthday) 
        {
            this.Faculty = faculty;
        }

        public string Faculty { get => faculty; set => faculty = value; }

        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}\nФамилия: {Surname}\nДата рождения: {Birthday}");
            Console.WriteLine($"Возвраст: {GetAge()}\nФакультет: {faculty}");
        }
        public static Abiturient Enter()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime birthday = new DateTime(year, month, day);
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            return new Abiturient(name, surname, birthday, faculty);
        }
    }
}
