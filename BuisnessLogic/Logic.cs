using DataAccesLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Logic
    {

        IRepository<User> repository = new EntityFrameworkRepository<User>();

        public void AddUser(string name, int iq, int balance) 
        {

            User user = new User() 
            {
            
                Name = name,
                IQ = iq,
                Balance = balance
            
            };
            repository.Add(user);
            repository.Save();
        
        }

        public IRepository<User> GetDataSource() 
        {
        
            return repository;
        
        }

    }
}
