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
        void ReadAll(T entity);
        void ReadByID(T entity);
        void Update(T entity);

    }
}
