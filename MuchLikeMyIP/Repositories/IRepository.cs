using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuchLikeMyIP.Repositories
{
    public interface IRepository<T> where T: Entity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void FindById(T entity);
    }
}
