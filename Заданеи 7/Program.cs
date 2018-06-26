using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заданеи_7
{
    class Program
    { 
        static void Main(string[] args)
        {
            int N = 0; // Длина слова
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 7");
            Console.ResetColor();
            Console.WriteLine("Введите длину кодовых слов:");
            while (!Int32.TryParse(Console.ReadLine(), out N) || (N <= 0) || (N > Int32.MaxValue))
                Console.WriteLine("Введите длину кодового слова больше 0, но меньше {0}", Int32.MaxValue);
            List<string> words = new List<string>(); //список слов 
            for (int i = 0; i < Math.Pow(3, N); i++) 
            {
                words.Add(Convert(i, N));
            } //генерация слов
            words.Sort();  //сортировка списка слов
            Console.WriteLine("Полученные кодовые слова:");
            foreach (var word in words) 
            {
                Console.WriteLine(word);
            } //вывод слов
            Console.ReadKey();
        }
        /// <summary>
        /// Преобразование в троичную систему
        /// </summary>
        /// <param name="before">Число для преобразования</param>
        /// <param name="n">Длина слова</param>
        /// <returns></returns>
        static string Convert(int before, int n)
        {
            string word = "";
            for (int i = 0; i < n; i++)
            {
                word += before % 3;
                before /= 3;
            }

            word.Reverse(); // Переворот слова                                            
            return word;
        }
    }
}

