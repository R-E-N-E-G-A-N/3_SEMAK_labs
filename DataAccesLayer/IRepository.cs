using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public interface IRepository<T> : IDisposable
    {

        void Add(T entity);
        void Delete(T entity);
        IEnumerable<T> ReadAll();
        IEnumerable<T> ReadByID();
        void Update(T entity);
        void Save();

    }
}
