using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;

namespace ConsoleApp1
{
    public class Program
    {
        private static readonly Logic _logic = new Logic(); 
        private static GameTasks _gameTasks;
        private static readonly Random _random = new Random();
        public enum GameTasks { FindImposter, Send, UpdateMinion, CreateNew }

        private static int? _countMinions;
        private static int? _imposterid;
        private static string? _keyHeight;
        private static int? _updateid;

        private static string? _grutext;
        static void Main(string[] args)
        {
            string prehistory = "Грю устал считать своих приспешников, поэтому попросил вас составить учет всех миньонов";
            foreach (var c in prehistory)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);
            while (Console.KeyAvailable) Console.ReadKey(true);
            Console.Clear();
            CreateTask();
            RenderScreen();
        }
        /// <summary>
        /// Выводит главное меню
        /// </summary>
        private static void RenderScreen()
        {
            while (true)
            {
                Console.WriteLine($"Грю: {_grutext}");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1. Добавить миньона\n2. Удалить миньона\n" +
                    "3. Изменить миньона\n4. Вывести всех миньонов\n5. Сгруппировать по росту и отправить на задание\n" +
                    "6. Поиск миньонов по имени\n7. Выход");
                Console.WriteLine("------------------------------------------");
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
        /// Случайно выбирает следующее задание
        /// </summary>
        private static void Tasks()
        {
            var tasks = new[] { GameTasks.CreateNew, GameTasks.UpdateMinion, GameTasks.FindImposter, GameTasks.Send };
            _gameTasks = tasks[_random.Next(tasks.Length)];
            switch (_gameTasks)
            {
                case GameTasks.CreateNew: CreateTask(); break;
                case GameTasks.Send: SendTask(); break;
                case GameTasks.FindImposter: FindImposterTask(); break;
                case GameTasks.UpdateMinion: UpdateTask(); break;
            }
        }
        /// <summary>
        /// Выводит информацию о задании по созданию миньона
        /// </summary>
        private static void CreateTask()
        {
            int needToCreate = _random.Next(1, 5);
            _grutext = $"Для учета требуется добавить {needToCreate} миньонов";
            _countMinions = _logic.GetALlMinions().Count + needToCreate;
        }
        /// <summary>
        /// Выводит информацию о задании по отправлению миньона с выбранным ростом
        /// </summary>
        private static void SendTask()
        {
            List<string> height = _logic.GroupByHeight().Keys.ToList();
            _keyHeight = height.ElementAt(_random.Next(height.Count));
            _grutext = $"Мне тут нужен {_keyHeight} миньон. Сгруппируй миньонов по росту и отправь нужного на задание";
        }
        /// <summary>
        /// Выводит информацию о задании по нахождению предателя
        /// </summary>
        private static void FindImposterTask()
        {
            if (_logic.GetALlMinions().Count != 0)
            {
                var imposter = _logic.GetALlMinions()[_random.Next(_logic.GetALlMinions().Count)];
                _imposterid = imposter.ID;
                _grutext = $"Я тут узнал, что среди миньонов есть один предатель.\nЭто {imposter}\nСрочно удали его!";
                return;
            }
            Tasks();
        }
        /// <summary>
        /// Выводит информацию о задании по изменению миньона
        /// </summary>
        private static void UpdateTask()
        {
            if (_logic.GetALlMinions().Count != 0)
            {
                var updateminion = _logic.GetALlMinions()[_random.Next(_logic.GetALlMinions().Count)];
                _updateid = updateminion.ID;
                _grutext = $"Слушай, {updateminion}\nявно неправильно занесен в список.Попробуй изменить его данные";
                return;
            }
            Tasks();
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
            if (list.Count == 0) { Console.WriteLine("Нет миньонов с таким ростом"); return; }
            foreach (var minion in list)
            {
                Console.WriteLine(minion);
            }
            if (_gameTasks == GameTasks.Send && key[choice-1] ==_keyHeight)
            {
                Console.WriteLine("Введите ID миньона, которого хотите отправить на задание:");
                while (true)
                {
                    try
                    {
                        int id = IntCheck();
                        if (!list.Any(m => m.ID == id))
                        {
                            Console.WriteLine("Выбранного id нет в данной категории");
                            continue;

                        }
                        _logic.RemoveMinion(id);
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.WriteLine($"Выбранный миньон отправлен на задание");
            }


        }

        /// <summary>
        /// Добавляет миньона
        /// </summary>
        private static void AddMinion()
        {
            if (_imposterid != null)
            {
                Console.WriteLine("Сначала срочно удали предателя");
                Console.ReadKey();
                return;
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите имя миньона:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите рост миньона:");
                    int height = IntCheck();
                    Console.WriteLine("Введите количество глаз миньона:");
                    bool istwoeyes = IntCheck(1, 2) == 2;
                    _logic.AddMinion(name, height, istwoeyes);
                    Console.WriteLine("Миньон успешно добавлен!");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
            if (_countMinions.HasValue && _countMinions.Value <= _logic.GetALlMinions().Count)
            {
                _countMinions = null;
                Tasks();
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
            while (true)
            {
                try
                {
                    int id = IntCheck();
                    _logic.RemoveMinion(id);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Выбранный миньон удален");
            if (_imposterid != null)
            {
                bool exists;
                try
                {
                    exists = _logic.GetMinionByID(_imposterid.Value) != null;
                }
                catch (ArgumentException)
                {
                    exists = false;
                }

                if (!exists)
                {
                    _imposterid = null;
                    Tasks();
                }
            }

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
            if (_imposterid != null)
            {
                Console.WriteLine("Сначала срочно удали предателя");
                Console.ReadKey();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Введите ID миньона, которого хотите изменить:");
            int id;
            while (true)
            {
                try
                {
                    id = IntCheck();
                    _logic.GetMinionByID(id);
                    break;
                }
                catch ( ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Выбранный миньон: {_logic.GetMinionByID(id)}");
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите имя миньона (если не хотите менять данный параментр нажмите Enter):");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Введите рост миньона (если не хотите менять данный параментр нажмите Enter):");
                    int? height = IntCheckOrNull();
                    Console.WriteLine("Введите количество глаз миньона (если не хотите менять данный параментр нажмите Enter):");
                    bool? istwoeyes = BoolCheckOrNull();
                    _logic.UpdateMinion(id, name, height, istwoeyes);
                    Console.WriteLine("Миньон успешно изменен!");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            if (_updateid != null && _updateid == id)
            {
                _updateid = null;
                Tasks();
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
        /// проверяет введенное знчение на число
        /// </summary>
        /// <returns>int число</returns>
        private static int IntCheck()
        {
            while (true)
            {
                try
                {
                    int check = int.Parse(Console.ReadLine());
                    return check;
                }
                catch
                {
                    Console.WriteLine("Введенное значение должно быть числом");
                }
            }
        }
        /// <summary>
        /// Проверяет введенное значение на 1,2 или null
        /// </summary>
        /// <returns>bool или null</returns>
        private static bool? BoolCheckOrNull()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return null;

                if (input == "1") return false;
                if (input == "2") return true;

                Console.WriteLine("Введите 1, 2 или Enter:");
            }
        }
        /// <summary>
        /// Проверяет введенное значение на число или null
        /// </summary>
        /// <returns>int число или null</returns>
        private static int? IntCheckOrNull()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return null;

                if (int.TryParse(input, out var value))
                    return value;

                Console.WriteLine("Введенное значение должно быть числом");
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
