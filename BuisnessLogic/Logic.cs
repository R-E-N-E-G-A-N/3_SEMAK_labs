using Model;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Logic
    {
        private readonly IRepository<Model.Gamer> _repository;

        /// <summary>
        /// Конструктор с внедрением зависимости через Entity Framework
        /// </summary>
        /// <param name="repository">Репозиторий для работы с данными</param>
        public Logic(IRepository<Model.Gamer> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Создает экземпляр Logic с Entity Framework репозиторием
        /// </summary>
        public Logic() : this(new EntityRepository(new DbContext()))
        {
        }
        
        /// <summary>
        /// Создает экземпляр Logic с Dapper репозиторием
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных</param>
        public Logic(string connectionString) : this(new DapperRepository(connectionString))
        {
        }

        public void AddGamer(string name, int iq, int balance) 
        {
            Model.Gamer gamer = new Model.Gamer() 
            {
                Name = name,
                IQ = iq,
                Balance = balance
            };
            _repository.Add(gamer);
        }
            
        public List<string> GetAll() 
        {
            var gamers = _repository.ReadAll();
            List<string> result = new List<string>();

            foreach (Model.Gamer gamer in gamers) 
            {
                result.Add(gamer.Name + " " + gamer.IQ + " " + gamer.Balance);
            }
            return result;
        }
                
        public void DeleteUser(string nickname)
        {
            var gamers = _repository.ReadAll();
            var gamerToDelete = gamers.FirstOrDefault(g => g.Name == nickname);
            
            if (gamerToDelete != null)
            {
                _repository.Delete(gamerToDelete.Id);
            }
        }

        public void ChangeUser(string nickname, int iq, int balance) 
        {
            var gamers = _repository.ReadAll();
            var gamerToUpdate = gamers.FirstOrDefault(g => g.Name == nickname);
            
            if (gamerToUpdate != null)
            {
                gamerToUpdate.IQ = iq;
                gamerToUpdate.Balance = balance;
                _repository.Update(gamerToUpdate);
            }
        }

        public bool CheckUser(string nickname) 
        {
            var gamers = _repository.ReadAll();
            return gamers.Any(g => g.Name.Equals(nickname));
        }

        /// <summary>
        /// Получает геймера по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор геймера</param>
        /// <returns>Найденный геймер или null</returns>
        public Model.Gamer GetGamerById(int id)
        {
            return _repository.ReadById(id);
        }

        /// <summary>
        /// Обновляет геймера по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор геймера</param>
        /// <param name="name">Новое имя</param>
        /// <param name="iq">Новый IQ</param>
        /// <param name="balance">Новый баланс</param>
        /// <returns>True, если геймер был обновлен</returns>
        public bool UpdateGamer(int id, string name, int iq, int balance)
        {
            var gamer = _repository.ReadById(id);
            if (gamer == null)
                return false;

            gamer.Name = name;
            gamer.IQ = iq;
            gamer.Balance = balance;
            
            return _repository.Update(gamer);
        }
    }
}
