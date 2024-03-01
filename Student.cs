using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._24
{
    class Student:Person
    {
        private string faculty;
        private string well;
        DateTime dateTime = DateTime.Now;

        public Student(string name, string surname, DateTime birthday, string faculty, string well) : base(name, surname, birthday)
        {
            this.Faculty = faculty;
            this.Well = well;
        }

        public string Faculty { get => faculty; set => faculty = value; }
        public string Well { get => well; set => well = value; }

        public override int Age()
        {
            return dateTime.Subtract(Birthday).Days / 365;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Возвраст: {Age()}\nФакультет: {faculty}\nКурс: {Well}");
        }
    }
}
