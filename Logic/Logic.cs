using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Model;

    namespace BuisnessLogic
    {
        /// <summary>
        /// Бизнес-логика для работы с миньонами
        /// </summary>
        public class Logic : ILogic 
        {
            private readonly IRepository<Minion> _repository;
            private readonly IBuisnessFunctionLogic _bflogic;
            public Logic(IRepository<Minion> repository, IBuisnessFunctionLogic bflogic)
            {
                _repository = repository;
                _bflogic = bflogic;
            }


            public void AddMinion(string name, int height, bool hastwoeyes)
            {
                LogicValidator.NameValid(name);
                LogicValidator.HeightValid(height);
                var minion = new Minion(name, height, hastwoeyes);
                _repository.Add(minion);
            }


            public List<Minion> GetALlMinions() { return _repository.GetAll().ToList(); }

            public void RemoveMinion(int id) 
            {
                var minion = _repository.ReadByID(id);
                if (minion == null)
                    throw new ArgumentException($"Миньон с id {id} не найден");
                _repository.Delete(id);
            }

            public void UpdateMinion(int id, string? name, int? height, bool? hastwoeyes)
            {
                var minion = _repository.ReadByID(id);
                if (minion == null)
                    throw new ArgumentException($"Миньон с id {id} не найден");
                if (!string.IsNullOrWhiteSpace(name)) {
                    LogicValidator.NameValid(name);
                    minion.Name = name; }
                if (height.HasValue)
                {
                    LogicValidator.HeightValid(height.Value);
                    minion.Height = height.Value;
                }
                if (hastwoeyes.HasValue) minion.HasTwoEyes = hastwoeyes.Value;
                _repository.Update(minion);
            }
            public Minion? GetMinionByID(int id)
            {
                return _repository.ReadByID(id);
            }

            public Dictionary<string, List<Minion>> GroupByHeight()
            {
                return _bflogic.GroupByHeight();
            }
            public List<Minion> SearchByName(string name)
            {
                return _bflogic.SearchByName(name);
            }
        }
    }
