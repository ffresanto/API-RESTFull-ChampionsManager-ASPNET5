using API_Champions_Manager.Data.VO;
using System.Collections.Generic;

namespace API_Champions_Manager.Business
{
    public interface IAwardBusiness
    {
        AwardVO Create(AwardVO award);
        AwardVO Update(AwardVO award);
        void Delete(long id);
        List<AwardVO> FindAll();
        AwardVO FindById(long id);
    }
}
