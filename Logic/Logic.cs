using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Logic
{
    /// <summary>
    /// Бизнес-логика для работы с миньонами
    /// </summary>
    public class Logic
    {
        private readonly IRepository<Minion> _repository;
        public const int MinHeight = 90;
        public const int MiddleHeight = 110;
        public const int HighHeight = 125;
        public const int MaxHeight = 140;
        private const string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chuigo\source\repos\AISsemester3\DataAccessLayer\Database1.mdf;Integrated Security=True";
        public Logic()
        {
            _repository = new EntityRepository<Minion>(new DBContext(connectionstring));
            //_repository = new DapperRepository<Minion>(connectionstring);
        }
        /// <summary>
        /// Добавляет нового миньона
        /// </summary>
        /// <param name="name">имя миньона</param>
        /// <param name="height">рость миньона</param>
        /// <param name="hastwoeyes">есть ли 2 глаза у миньона</param>
        /// <exception cref="ArgumentException">исключение: неправильный ввод данных</exception>
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

            var minion = new Minion(name, height, hastwoeyes);
            _repository.Add(minion);
        }

        /// <summary>
        /// Возвращает список миньонов
        /// </summary>
        /// <returns>список миньонов</returns>
        public List<Minion> GetALlMinions() { return _repository.GetAll().ToList(); }

        /// <summary>
        /// Удаляет миньона
        /// </summary>
        /// <param name="id">id миньона</param>
        /// <exception cref="ArgumentException">исключение: не найден миньон</exception>
        public void RemoveMinion(int id) 
        {
            var minion = _repository.ReadByID(id);
            if (minion == null)
                throw new ArgumentException($"Миньон с id {id} не найден");
            _repository.Delete(id);
        }
        /// <summary>
        /// Изменяет параметры миньона
        /// </summary>
        /// <param name="id">id иньона</param>
        /// <param name="name">имя миньона</param>
        /// <param name="height">рост миньона</param>
        /// <param name="hastwoeyes">есть ли 2 глаза у миньона</param>
        /// <exception cref="ArgumentException">исключение: неправильный ввод данных</exception>
        public void UpdateMinion(int id, string? name, int? height, bool? hastwoeyes)
        {
            var minion = _repository.ReadByID(id);
            if (minion == null)
                throw new ArgumentException($"Миньон с id {id} не найден");
            if (height < MinHeight || height > MaxHeight)
            {
                throw new ArgumentException($"Рост должен быть в диапазоне от {MinHeight} до {MaxHeight}");
            }
            if (!string.IsNullOrWhiteSpace(name)) minion.Name = name;
            if (height.HasValue) minion.Height = height.Value;
            if (hastwoeyes.HasValue) minion.HasTwoEyes = hastwoeyes.Value;
            _repository.Update(minion);
        }

        /// <summary>
        /// Получает миньона по id
        /// </summary>
        /// <param name="id">id миньона</param>
        /// <returns>миьнон</returns>
        public Minion GetMinionByID(int id)
        {
            var minion = _repository.ReadByID(id);
            if (minion == null)
            {
                throw new ArgumentException($"Миньона с таким id не существует");
            }
            return minion;

        }
        /// <summary>
        /// Группирует миньонов по росту
        /// </summary>
        /// <returns>словарь с категорией роста и списком</returns>
        public Dictionary<string, List<Minion>> GroupByHeight()
        {
            var minions = _repository.GetAll().ToList();
            return new Dictionary<string, List<Minion>>
            {
                ["Низкий"] = minions.Where(x => x.Height < MiddleHeight).ToList(),
                ["Средний"] = minions.Where(x => x.Height >= MiddleHeight && x.Height < HighHeight).ToList(),
                ["Высокий"] = minions.Where(x => x.Height >= HighHeight).ToList()
            };
        }

        /// <summary>
        /// Динамический поиск миньона по имени
        /// </summary>
        /// <param name="name">строка поиска</param>
        /// <returns>список миньонов с именем схожим со строкой поиска</returns>
        public List<Minion> SearchByName(string name)
        {
            return _repository.GetAll().Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
