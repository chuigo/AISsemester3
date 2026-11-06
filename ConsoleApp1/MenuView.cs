using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BuisnessLogic;
using Model;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    /// <summary>
    /// Коносольный слой представления
    /// </summary>
    public class MenuView
    {
        private readonly ILogic _logic;
        private readonly GameSession _gameSession;
        private readonly SearchView _searchView;

        public MenuView(ILogic logic, GameSession gameSession)
        {
            _logic = logic;
            _gameSession = gameSession;
            _searchView = new SearchView(logic);
        }
        /// <summary>
        /// Отрисовывает главное меню
        /// </summary>
        public void RenderScreen()
        {
            while (true)
            {
                Console.WriteLine($"Грю: {_gameSession.GruText}");
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
                    case "4": Console.Clear(); PrintMinions(); break;
                    case "5": Console.Clear(); GroupMinionByHeight(); break;
                    case "6": Console.Clear(); _searchView.RunSearch(); break;
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
        /// Запрашивает данные для добавления и добавляет миньона
        /// </summary>
        private void AddMinion()
        {
            if (_gameSession.ImposterExist())
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
                    int height = ConsoleInput.IntCheck();
                    Console.WriteLine("Введите количество глаз миньона:");
                    bool istwoeyes = ConsoleInput.IntCheck(1, 2) == 2;
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
            _gameSession.CompleteCreate();
        }
        /// <summary>
        /// Запрашивает данные для удаления и удаляет миньона
        /// </summary>
        private void RemoveMinion()
        {
            if (!PrintMinions())
            {
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Введите ID миньона, которого хотите удалить:");
            int id;
            while (true)
            {
                try
                {
                    id = ConsoleInput.IntCheck();
                    if (!_gameSession.CanDelete(id)) { Console.WriteLine("Выбранного миньона пока нельзя удалить"); return; }
                    _logic.RemoveMinion(id);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Выбранный миньон удален");
            _gameSession.CompleteImposter(id);
        }
        /// <summary>
        /// Запрашивает данные и обновляет миньона
        /// </summary>
        private void UpdateMinion()
        {
            if (!PrintMinions())
            {
                return;
            }
            if (_gameSession.ImposterExist())
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
                    id = ConsoleInput.IntCheck();
                    _logic.GetMinionByID(id);
                    break;
                }
                catch (ArgumentException ex)
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
                    int? height = ConsoleInput.IntCheckOrNull();
                    Console.WriteLine("Введите количество глаз миньона (если не хотите менять данный параментр нажмите Enter):");
                    bool? istwoeyes = ConsoleInput.BoolCheckOrNull();
                    _logic.UpdateMinion(id, name, height, istwoeyes);
                    Console.WriteLine("Миньон успешно изменен!");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            _gameSession.CompleteUpdate(id);
        }

        /// <summary>
        /// Группирует миньонов по росту
        /// </summary>
        private void GroupMinionByHeight()
        {
            Console.WriteLine("Выберите группировку миньонов по росту:\n" +
                "1. Низкий\n2. Средний\n3. Высокий");
            int choice = ConsoleInput.IntCheck(1, 3);
            Dictionary<string, List<Minion>> dictionaryHeight = _logic.GroupByHeight();
            string[] key = dictionaryHeight.Keys.ToArray();
            _logic.GroupByHeight().TryGetValue(key[choice - 1], out List<Minion> list);
            if (list.Count == 0) { Console.WriteLine("Нет миньонов с таким ростом"); return; }
            foreach (var minion in list)
            {
                Console.WriteLine(minion);
            }
            if (_gameSession.CanSend(key[choice - 1]))
            {
                Send(list);
            }
        }
        /// <summary>
        /// Отправляет миньона на задание
        /// </summary>
        /// <param name="list">список миньонов</param>
        private void Send(List<Minion> list)
        {
            Console.WriteLine("Введите ID миньона, которого хотите отправить на задание:");
            while (true)
            {
                try
                {
                    int id = ConsoleInput.IntCheck();
                    if (!list.Any(m => m.ID == id))
                    {
                        Console.WriteLine("Выбранного id нет в данной категории");
                        continue;

                    }
                    _logic.RemoveMinion(id);
                    _gameSession.CompleteSend();
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Выбранный миньон отправлен на задание");
        }
        /// <summary>
        /// Выводит всех миньонов
        /// </summary>
        /// <returns>true если миньоны есть, false иначе</returns>
        private bool PrintMinions()
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
    }

}
