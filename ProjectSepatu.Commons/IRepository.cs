using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Commons
{
    public interface IRepository<T> : IDisposable where T : ProductParent
    {
        void Save(T entity);
        void Delete(long id);
        T GetById(long id);
        List<T> GetAll();
    }
}
