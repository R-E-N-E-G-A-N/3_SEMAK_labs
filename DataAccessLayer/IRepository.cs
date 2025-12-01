using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Базовый интерфейс репозитория для выполнения CRUD операций
    /// </summary>
    /// <typeparam name="T">Тип доменного объекта</typeparam>
    public interface IRepository<T> where T : IDomainObject
    {
        /// <summary>
        /// Добавляет новый объект в хранилище
        /// </summary>
        /// <param name="entity">Объект для добавления</param>
        /// <returns>Идентификатор добавленного объекта</returns>
        int Add(T entity);

        /// <summary>
        /// Удаляет объект из хранилища по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта для удаления</param>
        /// <returns>True, если объект был удален, иначе False</returns>
        bool Delete(int id);

        /// <summary>
        /// Получает все объекты из хранилища
        /// </summary>
        /// <returns>Коллекция всех объектов</returns>
        List<T> ReadAll();

        /// <summary>
        /// Получает объект по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор объекта</param>
        /// <returns>Найденный объект или null</returns>
        T ReadById(int id);

        /// <summary>
        /// Обновляет существующий объект в хранилище
        /// </summary>
        /// <param name="entity">Объект с обновленными данными</param>
        /// <returns>True, если объект был обновлен, иначе False</returns>
        bool Update(T entity);
    }
}