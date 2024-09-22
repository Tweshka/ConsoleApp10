using Perfolizer.Mathematics.SignificanceTesting;
using System.Runtime.InteropServices;
using System.Text;

namespace LimlModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            {
                var studentsWithCoarses = from stud in students
                                          where stud.Age < 29 // берем всех студентов младше 29
                                          where stud.Languages.Contains("английский") // ищем тех, у кого в списке языков есть английский
                                          let birthYear = DateTime.Now.Year - stud.Age // Вычисляем год рождения
                                          from coarse in coarses
                                          where coarse.Name.Contains("C#") // теперь выбираем только курс по C#
                                          select new // выборка в новую сущность
                                          {
                                              Name = stud.Name,
                                              BirthYear = birthYear,
                                              CoarseName = coarse.Name
                                          };


                // выведем результат
                foreach (var stud in studentsWithCoarses)
                    Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) добавлен курс {stud.CoarseName}");
            }
        }
    }
}

