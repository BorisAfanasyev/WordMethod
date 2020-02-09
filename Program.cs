using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        /// <summary>
        /// Функция, обрабатывающая ввод текста и вывод результата для удаления кратных рядом стоящих символов в тексте
        /// </summary>
        static void RemoveRepeatedLettersOperate()
        {
            Console.WriteLine("Введите текст:");

            string text = Console.ReadLine();

            string newText = RemoveRepeatedLetters(text);

            Console.WriteLine("Новый текст:");
            Console.WriteLine(newText);
        }

        /// <summary>
        /// Функция для удаления кратных рядом стоящих символов в тексте
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Измененный текст</returns>
       static string RemoveRepeatedLetters(string text)
        {
            string newText = "";
            newText += text[0];
            string lowerText = text.ToLower();

            for (int i = 1; i < text.Length; i++)
            {
                if (lowerText[i] != lowerText[i - 1]) newText += text[i];
            }

            return newText;
        }
        static void Main(string[] args)
        {
            RemoveRepeatedLettersOperate();
           
  

            Console.ReadKey();
        }
    }
}
