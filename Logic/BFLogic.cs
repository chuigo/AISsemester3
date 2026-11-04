using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Model;

namespace BuisnessLogic
{
    public class BFLogic : IBuisnessFunctionLogic
    {
        private readonly IRepository<Minion> _repository;
        public BFLogic(IRepository<Minion> repository)
        {
            _repository = repository;
        }
        public Dictionary<string, List<Minion>> GroupByHeight()
        {
            var minions = _repository.GetAll().ToList();
            var result = new Dictionary<string, List<Minion>>();

            foreach (var category in HeightCategories.categories)
            {
                result[category.Name] = minions.Where(m => category.IsMatch(m.Height)).ToList();
            }

            return result;
        }
        public List<Minion> SearchByName(string name)
        {
            return _repository.GetAll().Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
