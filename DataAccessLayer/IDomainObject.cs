using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Базовый интерфейс для всех доменных объектов
    /// </summary>
    public interface IDomainObject
    {
        /// <summary>
        /// Уникальный идентификатор объекта
        /// </summary>
        int Id { get; set; }
    }
}