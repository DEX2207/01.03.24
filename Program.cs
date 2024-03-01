using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enter enter = new Enter();
            Console.Write("Введите тип персоны: ");
            string type = Console.ReadLine();
            List<object> list = new List<object>();
            switch (type)
            {
                case "Абитуриент":
                    enter.Abiturient();
                    break;
                case "Студент":
                    enter.Student();
                    break;

                case "Преподаватель":
                    enter.Teacher();
                    break;
                default:
                    Console.WriteLine("Неизвестная фигура");
                    break;
            }
        }
    }
}
