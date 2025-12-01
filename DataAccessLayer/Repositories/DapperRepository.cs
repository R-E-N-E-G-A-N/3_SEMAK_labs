using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLayer.Repositories
{
    /// <summary>
    /// Репозиторий для работы с базой данных через Dapper
    /// </summary>
    public class DapperRepository : IRepository<GamerEntity>
    {
        private readonly string _connectionString;

        /// <summary>
        /// Конструктор репозитория
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных</param>
        public DapperRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        /// <summary>
        /// Создает таблицу Gamers, если она не существует
        /// </summary>
        private void InitializeDatabase()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var createTableSql = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Gamers' AND xtype='U')
                    CREATE TABLE Gamers (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Name NVARCHAR(100) NOT NULL,
                        IQ INT NOT NULL,
                        Balance INT NOT NULL
                    )";
                
                connection.Execute(createTableSql);
            }
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

            InitializeDatabase();

            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Gamers (Name, IQ, Balance) VALUES (@Name, @IQ, @Balance); SELECT CAST(SCOPE_IDENTITY() as int)";
                
                var parameters = new
                {
                    entity.Name,
                    entity.IQ,
                    entity.Balance
                };

                var id = connection.Query<int>(sql, parameters).Single();
                entity.Id = id;
                return id;
            }
        }

        /// <summary>
        /// Удаляет геймера из базы данных по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор геймера для удаления</param>
        /// <returns>True, если геймер был удален, иначе False</returns>
        public bool Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Gamers WHERE Id = @Id";
                var rowsAffected = connection.Execute(sql, new { Id = id });
                return rowsAffected > 0;
            }
        }

        /// <summary>
        /// Получает всех геймеров из базы данных
        /// </summary>
        /// <returns>Коллекция всех геймеров</returns>
        public List<GamerEntity> ReadAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Gamers";
                var gamers = connection.Query<GamerEntity>(sql).ToList();
                return gamers;
            }
        }

        /// <summary>
        /// Получает геймера по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор геймера</param>
        /// <returns>Найденный геймер или null</returns>
        public GamerEntity ReadById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Gamers WHERE Id = @Id";
                var gamer = connection.QueryFirstOrDefault<GamerEntity>(sql, new { Id = id });
                return gamer;
            }
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

            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "UPDATE Gamers SET Name = @Name, IQ = @IQ, Balance = @Balance WHERE Id = @Id";
                var rowsAffected = connection.Execute(sql, entity);
                return rowsAffected > 0;
            }
        }
    }
}