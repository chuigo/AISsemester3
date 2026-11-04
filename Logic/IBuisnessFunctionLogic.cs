using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BuisnessLogic
{
    public interface IBuisnessFunctionLogic
    {
        /// <summary>
        /// Группирует миньонов по росту
        /// </summary>
        /// <returns>словарь, в котором ключ это категория роста, а значение это список миньонов с данным ростом</returns>
        public Dictionary<string, List<Minion>> GroupByHeight();

        /// <summary>
        /// Выполняет поиск миньонов, чьи имена содержат указанную подстроку
        /// </summary>
        /// <param name="name">подстрока для поиска</param>
        /// <returns>список миньонов, чьи имена содержат строку поиска</returns>
        public List<Minion> SearchByName(string name);
    }
}
