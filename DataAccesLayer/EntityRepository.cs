using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class EntityRepository<T> : IReposytory<T> where T : class, IDomainObject, new ()
    {

        public Context _context;

        public T Quest { get; set; }

        public EntityRepository()
        {
        
            _context = new Context();
        
        }

        public void Create(T item)
        {

            _context.Set<T>().Add(item);

        }

        public void Delete(T item)
        {

            _context.Set<T>().Remove(item);

        }

        public void Dispose()
        {

            _context.Dispose();

        }

        public IEnumerable<T> GetReposytory()
        {

            return (IEnumerable<T>)_context.quests;

        }

        public void Save()
        {

            _context.SaveChanges();

        }

        public void Update(T item)
        {

            _context.Set<T>().AddOrUpdate(item);

        }
    }
}
