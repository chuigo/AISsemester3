using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Бизнес-логика для работы с миньонами
    /// </summary>
    public class Logic
    {
        private readonly List<Minion> _minions = new List<Minion>();
        private int _id = 1;
        public const int MinHeight = 90;
        public const int MiddleHeight = 110;
        public const int HighHeight = 125;
        public const int MaxHeight = 140;

        /// <summary>
        /// Добавляет нового миньона
        /// </summary>
        /// <param name="name">имя миньона</param>
        /// <param name="height">рость миньона</param>
        /// <param name="hastwoeyes">есть ли 2 глаза у миньона</param>
        /// <exception cref="ArgumentException">исключение: неправильный ввод</exception>
        public void AddMinion(string name, int height, bool hastwoeyes)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }
            if (height < MinHeight || height > MaxHeight)
            {
                throw new ArgumentException($"Рост должен быть в диапазоне от {MinHeight} до {MaxHeight}");
            }

            var minion = new Minion(_id, name, height, hastwoeyes);
            _id++;
            _minions.Add(minion);
        }

        /// <summary>
        /// Возвращает список миньонов
        /// </summary>
        /// <returns>список миньонов</returns>
        public List<Minion> GetALlMinions() { return _minions; }

        /// <summary>
        /// Удаляет миньона
        /// </summary>
        /// <param name="id">id миньона</param>
        /// <exception cref="ArgumentException">исключение: не найден миньон</exception>
        public void RemoveMinion(int id) 
        {
            var minion = _minions.FirstOrDefault(x => x.ID == id);
            if (minion == null)
                throw new ArgumentException($"Миньон с id {id} не найден");
            _minions.Remove(minion);
        }
        /// <summary>
        /// Изменяет параметры миньона
        /// </summary>
        /// <param name="id">id иньона</param>
        /// <param name="name">имя миньона</param>
        /// <param name="height">рост миньона</param>
        /// <param name="hastwoeyes">есть ли 2 глаза у миньона</param>
        /// <exception cref="ArgumentException">исключение: неправильный ввод</exception>
        public void UpdateMinion(int id, string? name, int? height, bool? hastwoeyes)
        {
            var minion = _minions.FirstOrDefault(x => x.ID == id);
            if (minion == null)
                throw new ArgumentException($"Миньон с id {id} не найден");

            if (name != null)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Имя не может быть пустым");
                }

            }
            if (height < MinHeight || height > MaxHeight)
            {
                throw new ArgumentException($"Рост должен быть в диапазоне от {MinHeight} до {MaxHeight}");
            }
            if (name != null) minion.Name = name;
            if (height.HasValue) minion.Height = height.Value;
            if (hastwoeyes.HasValue) minion.HasTwoEyes = hastwoeyes.Value;
        }

        /// <summary>
        /// Получает миньона по id
        /// </summary>
        /// <param name="id">id миньона</param>
        /// <returns>миьнон</returns>
        public Minion GetMinionByID(int id)
        {
            return _minions.FirstOrDefault(x => x.ID == id);
        }
        /// <summary>
        /// Группирует миньонов по росту
        /// </summary>
        /// <returns>словарь с категорией роста и списком</returns>
        public Dictionary<string, List<Minion>> GroupByHeight()
        {
            return new Dictionary<string, List<Minion>>
            {
                ["Низкий"] = _minions.Where(x => x.Height < MiddleHeight).ToList(),
                ["Средний"] = _minions.Where(x => x.Height >= MiddleHeight && x.Height < HighHeight).ToList(),
                ["Высокий"] = _minions.Where(x => x.Height >= HighHeight).ToList()
            };
        }

        /// <summary>
        /// Динамический поиск миньона по имени
        /// </summary>
        /// <param name="name">строка поиска</param>
        /// <returns>список миньонов с именем схожим со строкой поиска</returns>
        public List<Minion> SearchByName(string name)
        {
            return _minions.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
