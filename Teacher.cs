using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1._03._24
{
    class Teacher : Person
    {
        private string faculty;
        private string well;
        private string jobtitle;
        private int experience;

        public Teacher(string name, string surname, DateTime birthday, string faculty,string jobtitle, int experience) : base(name, surname, birthday)
        {
            this.Faculty = faculty;
            this.jobtitle = jobtitle;
            this.Experience = experience;
        }

        public string Faculty { get => faculty; set => faculty = value; }
        public string Jobtitle { get => jobtitle; set => jobtitle = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Well { get => well; set => well = value; }

        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}\nФамилия: {Surname}\nДата рождения: {Birthday}");
            Console.WriteLine($"Возвраст: {GetAge()}\nФакультет: {faculty}\nДолжность: {jobtitle}\nСтаж: {Experience}");
        }
        public static Teacher Enter()
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
            Console.Write("Введите должность: ");
            string jobtitle = Console.ReadLine();
            Console.Write("Введите стаж: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            return new Teacher(name, surname, birthday, faculty, jobtitle, experience);
        }
    }
}
