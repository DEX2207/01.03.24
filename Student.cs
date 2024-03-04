using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1._03._24
{
    class Student:Person
    {
        private string faculty;
        private string well;

        public Student(string name, string surname, DateTime birthday, string faculty, string well) : base(name, surname, birthday)
        {
            this.Faculty = faculty;
            this.Well = well;
        }

        public string Faculty { get => faculty; set => faculty = value; }
        public string Well { get => well; set => well = value; }

        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}\nФамилия: {Surname}\nДата рождения: {Birthday}");
            Console.WriteLine($"Возвраст: {GetAge()}\nФакультет: {faculty}\nКурс: {Well}");
        }
        public static Student Enter()
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
            Console.Write("Введите курс: ");
            string well = Console.ReadLine();
            return new Student(name, surname, birthday, faculty, well);
        }
    }
}
