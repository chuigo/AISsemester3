using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
    public interface ILogic
    {
        /// <summary>
        /// Проверяет введенные данные на корректность и добавляет миньона в хранилище
        /// </summary>
        /// <param name="name">имя миньона</param>
        /// <param name="height">рост миньона</param>
        /// <param name="hastwoeyes">есть ли у миньона 2 глаза</param>
        public void AddMinion(string name, int height, bool hastwoeyes);
        /// <summary>
        /// Возвращает список миньонов из хранилища
        /// </summary>
        /// <returns>список миньонов</returns>
        public List<Minion> GetALlMinions();
        /// <summary>
        /// Удаляет миньона из хранилища 
        /// </summary>
        /// <param name="id">id миньона</param>
        public void RemoveMinion(int id);
        /// <summary>
        /// Проверяет корректность введенных данных и обновляет миньона в хранилище
        /// </summary>
        /// <param name="id">id миьнона</param>
        /// <param name="name">имя миньона</param>
        /// <param name="height">рост миьнона</param>
        /// <param name="hastwoeyes">есть ли у миьона 2 глаза</param>
        public void UpdateMinion(int id, string? name, int? height, bool? hastwoeyes);
        /// <summary>
        /// Возвращает миньона с указанным id
        /// </summary>
        /// <param name="id">id миньона</param>
        /// <returns>миньон с указанным id</returns>
        public Minion? GetMinionByID(int id);
        /// <summary>
        /// Группирует миньонов по росту
        /// </summary>
        /// <returns>словарь, в котором ключ - категория роста, а значение - список миньонов с данным ростом</returns>
        public Dictionary<string, List<Minion>> GroupByHeight();
        /// <summary>
        /// Выполняет поиск миньонов, чьи имена содержат указанную подстроку
        /// </summary>
        /// <param name="name">подстрока для поиска</param>
        /// <returns>список миньонов, чьи имена содержат строку поиска</returns>
        public List<Minion> SearchByName(string name);
    }
}
