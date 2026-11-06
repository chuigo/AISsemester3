using System;
using System.Collections.Generic;
using System.Text;
using BuisnessLogic;

namespace ConsoleApp1
{
    public class SearchView
    {
        private readonly ILogic _logic;

        public SearchView(ILogic logic)
        {
            _logic = logic;
        }
        /// <summary>
        /// Метод, считывающий клавиши для поиска
        /// </summary>
        /// <param name="logic"></param>
        public void RunSearch()
        {
            string name = "";
            while (true)
            {
                RenderSearchByName(name);
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
        /// <param name="name">введенная строка</param>
        public void RenderSearchByName(string name)
        {
            Console.Clear();
            Console.WriteLine("Введите имя миньона:");
            Console.WriteLine(name);
            Console.WriteLine();
            var resultList = _logic.SearchByName(name);
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
