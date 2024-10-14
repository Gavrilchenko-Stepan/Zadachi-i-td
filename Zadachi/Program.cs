using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] groups = { "П-10","П-21","П-40","П-32","Ю-11","Ю-22","Ю-30","Б-10","Б-20" }; //список всех групп
            //Console.WriteLine("Группы: " + String.Join(",", groups));

            Console.WriteLine("Введите букву: ");//ввод буквы

            string input = Console.ReadLine().ToString();// преобразуем введёную букву в строку
            
            Console.WriteLine("Группы, начинающиеся с быквы " + input + ":");

            foreach (string group in groups)//перебор групп в массиве группы
            {
                if (group.Contains(input))
                {
                    Console.WriteLine(group);
                }
                /*else
                {
                  !!!
                }
                */
            }
            Console.ReadKey();

        }
       
    }
}
