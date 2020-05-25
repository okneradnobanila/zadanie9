using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudLib;

namespace CshGit9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("\nВыберите действие:\n\n1) Показать информацию о студентах " +
                    "\n2) Добавить студента " +
                    "\n3) Удалить студента \n4) Изменить студента \n5) Поиск студента " +
                    "\n6) Выход\n");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {
                    Console.WriteLine("\nВыберите действие:\n\n1) Вся информация о студентах" +
                        "\n2) Список студентов с инициалами" +
                        "\n3) Список студентов старше 18\n4) Список студентов младше 18\n");
                    int n1 = Convert.ToInt32(Console.ReadLine());

                    if (n1 == 1)
                    {
                        Student.showlist();
                        continue;
                    }
                    if (n1 == 2)
                    {
                        Student.initials();
                        continue;
                    }
                    if (n1 == 3)
                    {
                        Student.starshe();
                        continue;
                    }
                    if (n1 == 4)
                    {
                        Student.mladshe();
                        continue;
                    }

                }

                if (n == 2)
                {
                    Student.newstudent();
                    continue;
                }

                if (n == 3)
                {
                    Student.deletestudent();
                    continue;
                }

                if (n == 4)
                {
                    Student.correctinfo();
                    continue;
                }

                if (n == 5)
                {
                    Student.poisk();
                    continue;
                }

                if (n == 6)
                {
                    Student.close();
                }
            }
        }
    }
}