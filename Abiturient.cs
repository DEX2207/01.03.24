using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._24
{
    class Abiturient:Person
    {
        private string faculty;
        DateTime dateTime = DateTime.Now;

        public Abiturient(string name, string surname, DateTime birthday,string faculty): base(name,surname,birthday) 
        {
            this.Faculty = faculty;
        }

        public string Faculty { get => faculty; set => faculty = value; }

        public override int Age()
        {
           return dateTime.Subtract(Birthday).Days/365;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Возвраст: {Age()}\nФакультет: {faculty}");
        }
    }
}
