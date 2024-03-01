using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._24
{
    abstract class Person
    {
        private string name;
        private string surname;
        private DateTime birthday;

        public Person(string name,string surname,DateTime birthday) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public abstract int Age();
        public virtual void Print()
        {
            Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nДата рождения: {birthday}");
        }
    }
}
