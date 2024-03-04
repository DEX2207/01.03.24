using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            bool a=true;
            while (a==true) 
            {
                Console.WriteLine("1.Ввод персоны в базу данных\n2.Вывод базы данных о персоне\n3.Поиск персоны по возрасту\n4.Выход");
                char number=Convert.ToChar(Console.ReadLine());
                switch (number) 
                {
                    case '1':
                        Console.Write("Введите тип персоны: ");
                        string type = Console.ReadLine();
                        switch (type)
                        {
                            case "Абитуриент":
                                list.Add(Abiturient.Enter());
                                break;
                            case "Студент":
                                list.Add(Student.Enter());
                                break;

                            case "Преподаватель":
                                list.Add(Teacher.Enter());
                                break;
                            default:
                                Console.WriteLine("Неизвестный тип");
                                return;
                        }
                        break;
                    case '2':
                      foreach (var elem in list)
                        {
                            elem.Print();
                        }
                        break;
                    case '3':
                        Console.Write("Введите нижнюю границу: ");
                        int minAge=Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите верхнюю границу: ");
                        int maxAge = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].GetAge() > minAge && list[i].GetAge() < maxAge)
                            {
                                list[i].Print();
                            }
                        }
                        break;
                    case '4':
                        a = false;
                        break;
                }
                
            }
        }
    }
}
