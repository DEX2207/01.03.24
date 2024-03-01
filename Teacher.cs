using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._24
{
    class Teacher:Person
    {
        private string faculty;
        private string well;
        private string jobtitle;
        private int experience;
        DateTime dateTime = DateTime.Now;

        public Teacher(string name, string surname, DateTime birthday, string faculty,string jobtitle, int experience) : base(name, surname, birthday)
        {
            this.Faculty = faculty;
            this.jobtitle = jobtitle;
            this.Experience = experience;
        }

        public string Faculty { get => faculty; set => faculty = value; }
        public string Jobtitle { get => jobtitle; set => jobtitle = value; }
        public int Experience { get => experience; set => experience = value; }

        public override int Age()
        {
            return dateTime.Subtract(Birthday).Days / 365;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Возвраст: {Age()}\nФакультет: {faculty}\nДолжность: {jobtitle}\nСтаж: {Experience}");
        }
    }
}
