using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    /// <summary>
    /// Репозиторий для работы с базой данных через Entity Framework
    /// </summary>
    public class EntityRepository : IRepository<GamerEntity>
    {
        private readonly DbContext _context;

        /// <summary>
        /// Конструктор репозитория
        /// </summary>
        /// <param name="context">Контекст базы данных</param>
        public EntityRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Добавляет нового геймера в базу данных
        /// </summary>
        /// <param name="entity">Сущность геймера для добавления</param>
        /// <returns>Идентификатор добавленного геймера</returns>
        public int Add(GamerEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _context.Gamers.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        /// <summary>
        /// Удаляет геймера из базы данных по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор геймера для удаления</param>
        /// <returns>True, если геймер был удален, иначе False</returns>
        public bool Delete(int id)
        {
            var gamer = _context.Gamers.Find(id);
            if (gamer == null)
                return false;

            _context.Gamers.Remove(gamer);
            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Получает всех геймеров из базы данных
        /// </summary>
        /// <returns>Коллекция всех геймеров</returns>
        public List<GamerEntity> ReadAll()
        {
            return _context.Gamers.ToList();
        }

        /// <summary>
        /// Получает геймера по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор геймера</param>
        /// <returns>Найденный геймер или null</returns>
        public GamerEntity ReadById(int id)
        {
            return _context.Gamers.Find(id);
        }

        /// <summary>
        /// Обновляет данные геймера в базе данных
        /// </summary>
        /// <param name="entity">Сущность геймера с обновленными данными</param>
        /// <returns>True, если геймер был обновлен, иначе False</returns>
        public bool Update(GamerEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var existingGamer = _context.Gamers.Find(entity.Id);
            if (existingGamer == null)
                return false;

            // Обновляем свойства существующего объекта
            existingGamer.Name = entity.Name;
            existingGamer.IQ = entity.IQ;
            existingGamer.Balance = entity.Balance;

            _context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Освобождает ресурсы контекста
        /// </summary>
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}