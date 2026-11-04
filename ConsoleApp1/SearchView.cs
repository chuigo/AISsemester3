using System;
using System.Collections.Generic;
using System.Text;
using BuisnessLogic;

namespace ConsoleApp1
{
    public class SearchView
    {
        /// <summary>
        /// Метод, считывающий клавиши для поиска
        /// </summary>
        /// <param name="logic"></param>
        public static void RunSearch(Logic logic)
        {
            string name = "";
            while (true)
            {
                RenderSearchByName(name,logic);
                var key = Console.ReadKey(intercept: true);
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (name.Length > 0)
                    {
                        name = name.Substring(0, name.Length - 1);
                    }
                }
                if (!char.IsControl(key.KeyChar))
                {
                    name += key.KeyChar;
                }
            }
        }
        /// <summary>
        /// Метод, отрисовывающий экран поиска
        /// </summary>
        /// <param name="name"></param>
        /// <param name="logic"></param>
        public static void RenderSearchByName(string name, Logic logic)
        {
            Console.Clear();
            Console.WriteLine("Введите имя миньона:");
            Console.WriteLine(name);
            Console.WriteLine();
            var resultList = logic.SearchByName(name);
            if (resultList == null)
            {
                Console.WriteLine("Ничего не найдено");
            }
            else
            {
                foreach (var minion in resultList)
                {
                    Console.WriteLine(minion);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите Esc для выхода");
            Console.SetCursorPosition(name.Length, 1);
        }
    }
}
