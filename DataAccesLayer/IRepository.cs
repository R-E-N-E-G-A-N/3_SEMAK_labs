using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public interface IReposytory<T> : IDisposable where T : class
    {
         
        IEnumerable<T> GetReposytory();

        T Quest { get; set; }

        void Create(T item);

        void Update(T item);

        void Delete(T item);

        void Save();

    }
}
