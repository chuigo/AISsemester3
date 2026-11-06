using System;
using System.Collections.Generic;
using System.Text;

    namespace BuisnessLogic
    {
        public enum GameTasks { FindImposter, Send, UpdateMinion, CreateNew }
        public class GameSession
        {
            private readonly ILogic _logic;
            private readonly Random _random = new Random();
            public GameTasks CurrentTask { get; private set; }
            public int? CountMinions { get; private set; } 
            public int? ImposterID { get; private set; }
            public string? KeyHeight { get; private set; }
            public int? UpdateID { get; private set; }
            public string? GruText {get; private set;}
            public event Action? TaskChanged;
            public GameSession(ILogic logic)
            {
                _logic = logic;
                CurrentTask = GameTasks.CreateNew;
                CreateTask();
            }
            public void NextTask()
            {
                var tasks = new[] { GameTasks.CreateNew, GameTasks.UpdateMinion, GameTasks.FindImposter, GameTasks.Send };
                CurrentTask = tasks[_random.Next(tasks.Length)];
                switch (CurrentTask)
                {
                    case GameTasks.CreateNew: CreateTask(); break;
                    case GameTasks.Send: SendTask(); break;
                    case GameTasks.FindImposter: FindImposterTask(); break;
                    case GameTasks.UpdateMinion: UpdateTask(); break;
                }
                TaskChanged?.Invoke();
        }
            private void CreateTask()
            {
                int needToCreate = _random.Next(1, 5);
                GruText = $"Для учета требуется добавить {needToCreate} миньонов";
                CountMinions = _logic.GetALlMinions().Count + needToCreate;
            }
            private void SendTask()
            {
                List<string> height = _logic.GroupByHeight().Keys.ToList();
                KeyHeight = height.ElementAt(_random.Next(height.Count));
                GruText = $"Мне тут нужен {KeyHeight} миньон. Сгруппируй миньонов по росту и отправь нужного на задание";
            }
            private void FindImposterTask()
            {
                if (_logic.GetALlMinions().Count != 0)
                {
                    var imposter = _logic.GetALlMinions()[_random.Next(_logic.GetALlMinions().Count)];
                    ImposterID = imposter.ID;
                    GruText = $"Я тут узнал, что среди миньонов есть один предатель.\nЭто {imposter}\nСрочно удали его!";
                    return;
                }
                NextTask();
            }

            private void UpdateTask()
            {
                if (_logic.GetALlMinions().Count != 0)
                {
                    var updateminion = _logic.GetALlMinions()[_random.Next(_logic.GetALlMinions().Count)];
                    UpdateID = updateminion.ID;
                    GruText = $"Слушай, {updateminion}\nявно неправильно занесен в список.Попробуй изменить его данные";
                    return;
                }
                NextTask();
            }

            public bool ImposterExist()
            {
              if (ImposterID.HasValue)
                {
                    return true;
                }
                return false;
            }

            public bool CanSend(string key)
            {
                if (CurrentTask == GameTasks.Send && key == KeyHeight)
                {
                    return true;
                }
                return false;

            }
            public bool CanDelete(int id)
            {
                if (UpdateID == id)
                {
                    return false;
                }
                return true;
            }
            public void CompleteCreate()
            {
                if (CurrentTask != GameTasks.CreateNew) return;
                if (CountMinions.HasValue && _logic.GetALlMinions().Count >= CountMinions)
                {
                    CountMinions = null;
                    NextTask();
                }
            }
            public void CompleteImposter(int id)
            {
                if (CurrentTask != GameTasks.FindImposter) return;
                if (ImposterID == id)
                {
                    ImposterID = null;
                    NextTask();
                }
            }
            public void CompleteUpdate(int id)
            {
                if (CurrentTask != GameTasks.UpdateMinion) return;
                if (UpdateID == id)
                {
                    UpdateID = null;
                    NextTask();
                }
            }
            public void CompleteSend()
            {
                if (CurrentTask != GameTasks.Send) return;
                KeyHeight = null;
                NextTask();
            }
        }
    }
