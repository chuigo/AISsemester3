using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Model;

namespace ConsoleApp
{
    public class Program
    {
        private static readonly Logic _logic = new Logic();
        static void Main(string[] args)
        {
            string prehistory = "Грю устал считать своих приспешников, поэтому попросил вас составить учет всех миньонов";
            foreach (var c in prehistory)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);
            Console.Clear();
            while (true)
            {
                
                Console.WriteLine("1. Добавить миньона\n2. Удалить миньона\n" +
                    "3. Изменить миньона\n4. Вывести всех миньонов\n5. Сгруппировать по росту\n" +
                    "6. Поиск миньонов по имени\n7. Выход");
                Console.WriteLine("Выберите действие:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": Console.Clear(); AddMinion(); break;
                    case "2": Console.Clear(); RemoveMinion(); break;
                    case "3": Console.Clear(); UpdateMinion(); break;
                    case "4": Console.Clear(); GetMinions(); break;
                    case "5": Console.Clear(); GroupMinionByHeight(); break;
                    case "6": Console.Clear(); SearchByName(); break;
                    case "7": return;
                    default: Console.WriteLine("Введен неверный символ, попробуйте еще раз:"); break;
                }
                Console.WriteLine();
                Console.WriteLine("Для продолжения введите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        /// <summary>
        /// Группировка миньонов по росту
        /// </summary>
        private static void GroupMinionByHeight()
        {
            Console.WriteLine("Выберите группировку миньонов по росту:\n" +
                "1. Низкий\n2. Средний\n3. Высокий");
            int choice = IntCheck(1,3);
            Dictionary<string,List<Minion>> dictionaryHeight = _logic.GroupByHeight();
            string[] key = dictionaryHeight.Keys.ToArray();
            _logic.GroupByHeight().TryGetValue(key[choice-1], out List<Minion> list);
            foreach (var minion in list)
            {
                Console.WriteLine(minion);
            }
            if (list.Count == 0) { Console.WriteLine("Нет миньонов с таким ростом"); }


        }

        /// <summary>
        /// Добавляет миньона
        /// </summary>
        private static void AddMinion()
        {
            Console.WriteLine("Введите имя миньона:");
            string name = StringCheck();
            Console.WriteLine("Введите рост миньона:");
            int height = IntCheck(Logic.MinHeight,Logic.MaxHeight);
            Console.WriteLine("Введите количество глаз миньона:");
            bool istwoeyes = IntCheck(1, 2) == 2;
            try
            {
                _logic.AddMinion(name, height, istwoeyes);
                Console.WriteLine("Миньон успешно добавлен!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            
        }
        /// <summary>
        /// Выводит список миньонов
        /// </summary>
        /// <returns>bool для определения есть ли миньоны в списке</returns>
        private static bool GetMinions()
        {
            if (_logic.GetALlMinions().Count == 0)
            {
                Console.WriteLine("Список миньонов пуст!");
                return false;
            }
            var listMinions = _logic.GetALlMinions();
            foreach (var minion in listMinions)
            {
                Console.WriteLine(minion);
            }
            return true;
        }
        /// <summary>
        /// Удаляет миньона
        /// </summary>
        private static void RemoveMinion()
        {
            if (!GetMinions())
            {
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Введите ID миньона, которого хотите удалить:");
            int[] range = _logic.GetALlMinions().Select(m => m.ID).ToArray();
            int id = IntCheck(range);
            _logic.RemoveMinion(id);
            Console.WriteLine($"Выбранный миньон удален");

        }
        /// <summary>
        /// Обновляет данные миньона
        /// </summary>
        private static void UpdateMinion() 
        {
            if (!GetMinions())
            {
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Введите ID миньона, которого хотите изменить:");
            int[] range = _logic.GetALlMinions().Select(m => m.ID).ToArray();
            int id = IntCheck(range);
            Console.WriteLine($"Выбранный миньон: {_logic.GetMinionByID(id)}");

            Console.WriteLine("Введите имя миньона:");
            string name = StringCheck();
            Console.WriteLine("Введите рост миньона:");
            int height = IntCheck(90, 200);
            Console.WriteLine("Введите количество глаз миньона:");
            bool istwoeyes = IntCheck(1, 2) == 2;

            try
            {
                _logic.UpdateMinion(id, name, height, istwoeyes);
                Console.WriteLine("Миньон успешно изменен!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        /// <summary>
        /// Проверяет введенное значение на строку
        /// </summary>
        /// <returns>string</returns>
        private static string StringCheck()
        {
            while (true)
            {
                string check = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(check))
                {
                    return check;
                }
                Console.WriteLine("Строка не может быть пустой, попробуйте еще раз:");
            }
        }
        /// <summary>
        /// Проверяет введенное значение на число и нахождение этого числа в заданном диапазоне
        /// </summary>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <returns>int</returns>
        private static int IntCheck(int min, int max)
        {
            while (true)
            {
                try
                {
                    int check = int.Parse(Console.ReadLine());
                    if (check <= max && check >= min)
                    {
                        return check;
                    }
                    Console.WriteLine($"Значение должно быть в диапазоне от {min} до {max}");
                }
                catch
                {
                    Console.WriteLine("Введенное значение должно быть числом и находиться в диапазоне " +
                        $"от {min} до {max}");
                }
            }
        }
        /// <summary>
        /// Проверяет введенное значение на число и нахождение этого числа в заданном массиве
        /// </summary>
        /// <param name="range">Массив чисел</param>
        /// <returns></returns>
        private static int IntCheck(int[] range)
        {
            while (true)
            {
                try
                {
                    int check = int.Parse(Console.ReadLine());
                    if (range.Contains(check))
                    {
                        return check;
                    }
                    Console.WriteLine($"Введенного ID не существует");
                }
                catch
                {
                    Console.WriteLine("Введенное значение должно быть числом");
                }
            }
        }

        /// <summary>
        /// Ищет миньона по имени
        /// </summary>
        private static void SearchByName()
        {
            if (!GetMinions())
            {
                return;
            }
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
                        name= name.Substring(0, name.Length -1);
                    }
                }
                if (!char.IsControl(key.KeyChar))
                {
                    name += key.KeyChar;
                }
            }
        }

        /// <summary>
        /// Отрисовывает экран поиска
        /// </summary>
        /// <param name="name">введенное имя</param>
        private static void RenderSearchByName(string name)
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
