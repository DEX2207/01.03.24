using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._24
{
    internal class Enter
    {
        public void Abiturient()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime birthday = DateTime.Now;
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Abiturient abiturient = new Abiturient(name, surname, birthday, faculty);
        }
        public void Student()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime birthday = DateTime.Now;
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Введите курс: ");
            string well= Console.ReadLine();
            Student student = new Student (name, surname, birthday, faculty,well);
        }
        public void Teacher()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime birthday = DateTime.Now;
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Введите должность: ");
            string jobtitle = Console.ReadLine();
            Console.Write("Введите стаж: ");
            int experience=Convert.ToInt32(Console.ReadLine());
            Teacher teacher = new Teacher(name, surname, birthday, faculty, jobtitle, experience);
        }

    }
}
