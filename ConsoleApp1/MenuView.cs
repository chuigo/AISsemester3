using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BuisnessLogic;
using Game;
using Model;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    /// <summary>
    /// Коносольный слой представления
    /// </summary>
    public class MenuView
    {
        /// <summary>
        /// Отрисовывает главное меню
        /// </summary>
        /// <param name="logic">экземпляр бизнес-логики</param>
        /// <param name="gameSession">текущая игровая сессия</param>
        public static void RenderScreen(Logic logic, GameSession gameSession)
        {
            while (true)
            {
                Console.WriteLine($"Грю: {gameSession.GruText}");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1. Добавить миньона\n2. Удалить миньона\n" +
                    "3. Изменить миньона\n4. Вывести всех миньонов\n5. Сгруппировать по росту и отправить на задание\n" +
                    "6. Поиск миньонов по имени\n7. Выход");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Выберите действие:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": Console.Clear(); AddMinion(logic, gameSession); break;
                    case "2": Console.Clear(); RemoveMinion(logic, gameSession); break;
                    case "3": Console.Clear(); UpdateMinion(logic, gameSession); break;
                    case "4": Console.Clear(); PrintMinions(logic); break;
                    case "5": Console.Clear(); GroupMinionByHeight(logic, gameSession); break;
                    case "6": Console.Clear(); SearchView.RunSearch(logic); break;
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
        /// <param name="logic">экземпляр бизнес-логики</param>
        /// <param name="gameSession">текущая игровая сессия</param>
        private static void AddMinion(Logic logic, GameSession gameSession)
        {
            if (gameSession.ImposterExist())
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
                    logic.AddMinion(name, height, istwoeyes);
                    Console.WriteLine("Миньон успешно добавлен!");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine();
                }
            }
            gameSession.CompleteCreate();
        }
        /// <summary>
        /// Запрашивает данные для удаления и удаляет миньона
        /// </summary>
        /// <param name="logic">экземпляр бизнес-логики</param>
        /// <param name="gameSession">текущая игровая сессия</param>
        private static void RemoveMinion(Logic logic, GameSession gameSession)
        {
            if (!PrintMinions(logic))
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
                    if (!gameSession.CanDelete(id)) { Console.WriteLine("Выбранного миньона пока нельзя удалить"); return; }
                    logic.RemoveMinion(id);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Выбранный миньон удален");
            gameSession.CompleteImposter(id);
        }
        /// <summary>
        /// Запрашивает данные и обновляет миньона
        /// </summary>
        /// <param name="logic">экземпляр бизнес-логики</param>
        /// <param name="gameSession">текущая игровая сессия</param>
        private static void UpdateMinion(Logic logic, GameSession gameSession)
        {
            if (!PrintMinions(logic))
            {
                return;
            }
            if (gameSession.ImposterExist())
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
                    logic.GetMinionByID(id);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Выбранный миньон: {logic.GetMinionByID(id)}");
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
                    logic.UpdateMinion(id, name, height, istwoeyes);
                    Console.WriteLine("Миньон успешно изменен!");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            gameSession.CompleteUpdate(id);
        }

        /// <summary>
        /// Группирует миньонов по росту
        /// </summary>
        /// <param name="logic">экземпляр бизнес-логики</param>
        /// <param name="gameSession">текущая игровая сессия</param>
        private static void GroupMinionByHeight(Logic logic, GameSession gameSession)
        {
            Console.WriteLine("Выберите группировку миньонов по росту:\n" +
                "1. Низкий\n2. Средний\n3. Высокий");
            int choice = ConsoleInput.IntCheck(1, 3);
            Dictionary<string, List<Minion>> dictionaryHeight = logic.GroupByHeight();
            string[] key = dictionaryHeight.Keys.ToArray();
            logic.GroupByHeight().TryGetValue(key[choice - 1], out List<Minion> list);
            if (list.Count == 0) { Console.WriteLine("Нет миньонов с таким ростом"); return; }
            foreach (var minion in list)
            {
                Console.WriteLine(minion);
            }
            if (gameSession.CanSend(key[choice - 1]))
            {
                Send(logic, list, gameSession);
            }
        }
        /// <summary>
        /// Отправляет миньона на задание
        /// </summary>
        /// <param name="logic">экземпляр бизнес-логики</param>
        /// <param name="list">список миньонов</param>
        /// <param name="gameSession">текущая игровая сессия</param>
        private static void Send(Logic logic, List<Minion> list, GameSession gameSession)
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
                    logic.RemoveMinion(id);
                    gameSession.CompleteSend();
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
        /// <param name="logic">экземпляр бизнес-логики</param>
        /// <returns>true если миньоны есть, false иначе</returns>
        private static bool PrintMinions(Logic logic)
        {
            if (logic.GetALlMinions().Count == 0)
            {
                Console.WriteLine("Список миньонов пуст!");
                return false;
            }
            var listMinions = logic.GetALlMinions();
            foreach (var minion in listMinions)
            {
                Console.WriteLine(minion);
            }
            return true;
        }
    }

}
