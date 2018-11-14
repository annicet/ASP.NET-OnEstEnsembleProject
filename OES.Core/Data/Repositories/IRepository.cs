using System;
using System.Collections.Generic;
using System.Text;

namespace OnEstEnsemble.Core.Data.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetList();
        T GetById(decimal key);
        void Insert(T entity);
        void Delete(T entity);
        void update(decimal key, T entity);
    }
}
