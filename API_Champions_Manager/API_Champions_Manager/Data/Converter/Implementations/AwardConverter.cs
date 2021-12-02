using API_Champions_Manager.Data.Converter.Contract;
using API_Champions_Manager.Data.VO;
using API_Champions_Manager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Champions_Manager.Data.Converter.Implementations
{
    public class AwardConverter : IParser<AwardVO, Award>, IParser<Award, AwardVO>
    {
        public Award Parse(AwardVO origin)
        {
            if (origin == null) return null;
            return new Award
            {
                Id = origin.Id,
                Name = origin.Name,
                Origin = origin.Origin,
                Organization = origin.Organization,
                National = origin.National
            };
        }
     
        public List<Award> Parse(List<AwardVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        #region VO

        public AwardVO Parse(Award origin)
        {
            if (origin == null) return null;
            return new AwardVO
            {
                Id = origin.Id,
                Name = origin.Name,
                Origin = origin.Origin,
                Organization = origin.Organization,
                National = origin.National
            };
        }

        public List<AwardVO> Parse(List<Award> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        #endregion

    }
}
