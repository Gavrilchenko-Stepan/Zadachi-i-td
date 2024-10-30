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
            Console.WriteLine("Группы: " + String.Join(",", groups));

            Console.WriteLine("Введите номер курса: "); //ввод номера курса
            string input = Console.ReadLine();
            int.TryParse(input, out int result); //преобразуем строку в целое число
            foreach (string group in groups)
            {
                char number = group[2];
                if (number == (char)('0' + result)) // проверяет равенство символа number и символа полученного при сложении
                {
                    Console.WriteLine(group);
                }
                else 
                {
                    Console.WriteLine("Ошибка! Введите номер курас от 1 до 4!");
                }
            }



            Console.ReadKey();

        }
       
    }
}
