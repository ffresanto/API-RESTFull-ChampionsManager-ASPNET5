using API_Champions_Manager.Model;
using API_Champions_Manager.Model.Base;
using System.Collections.Generic;

namespace API_Champions_Manager.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item); // item = Class Model
        T Update(T item);
        void Delete(long id);
        List<T> FindAll();
        T FindById(long id);
        bool Exists(long id);
    }
}
