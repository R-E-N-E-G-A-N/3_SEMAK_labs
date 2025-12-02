using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class EntityFrameworkRepository<T> : IRepository<T>
        where T : class, IDomainObject, new()
    {

        Context _context;

        public EntityFrameworkRepository() 
        {
        
            _context = new Context();
        
        }

        public void Add(T entity)
        {

            _context.Set<T>().Add(entity);

        }

        public void Delete(T entity)
        {

            _context.Set<T>().Remove(entity);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ReadAll()
        {

            return _context.Set<T>();
            
        }

        public IEnumerable<T> ReadByID()
        {

            return _context.Set<T>().OrderBy(x => x.Id);

        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    
        public void Save() 
        {
        
            _context.SaveChanges();
        
        }

    }
}
