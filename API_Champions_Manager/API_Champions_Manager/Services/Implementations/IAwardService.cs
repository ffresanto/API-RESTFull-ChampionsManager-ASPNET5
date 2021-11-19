using API_Champions_Manager.Model;
using System.Collections.Generic;

namespace API_Champions_Manager.Services.Implementations
{
    public interface IAwardService
    {
        Award Create(Award award);
        Award Update(Award award);
        void Delete(Award award);
        List<Award> FindAll();
        Award FindById(long id);
    }
}
