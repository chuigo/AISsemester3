using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
    /// <summary>
    /// Интерфейс репозитория с CRUD операцями
    /// </summary>
    public interface IRepository<T> where T : IDomainObject
    {
        /// <summary>
        /// Создает новую сущность в бд
        /// </summary>
        /// <param name="obj">сущность для создания</param>
        void Add(T obj);

        /// <summary>
        /// Возвращает всех сущностей из бд
        /// </summary>
        /// <returns> коллекция сущностей типа T</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Возвращает сущность с указанным id
        /// </summary>
        /// <param name="id">идентификатор сущности</param>
        /// <returns>сущность с указанным id или null, если сущность не найдена</returns>
        T? ReadByID(int id);

        /// <summary>
        /// Обновляет существующую сущность в бд
        /// </summary>
        /// <param name="obj">сущность для изменения</param>
        void Update(T obj);

        /// <summary>
        /// Удаляет сущность с указанным id из бд
        /// </summary>
        /// <param name="id">идентификатор сущности</param>
        void Delete(int id);

    }
}
