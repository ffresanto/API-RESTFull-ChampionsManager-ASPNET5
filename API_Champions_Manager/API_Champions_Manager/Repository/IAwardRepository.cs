using API_Champions_Manager.Model;
using System.Collections.Generic;

namespace API_Champions_Manager.Repository
{
    public interface IAwardRepository
    {
        Award Create(Award award);
        Award Update(Award award);
        void Delete(long id);
        List<Award> FindAll();
        Award FindById(long id);
        bool Exists(long id);
    }
}
