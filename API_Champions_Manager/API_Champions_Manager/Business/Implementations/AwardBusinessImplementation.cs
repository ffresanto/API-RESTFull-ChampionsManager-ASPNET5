using API_Champions_Manager.Data.Converter.Implementations;
using API_Champions_Manager.Data.VO;
using API_Champions_Manager.Model;
using API_Champions_Manager.Repository.Generic;
using System.Collections.Generic;

namespace API_Champions_Manager.Business.Implementations
{
    public class AwardBusinessImplementation : IAwardBusiness
    {
        private readonly IRepository<Award> _repository;
        private readonly AwardConverter _converter;

        public AwardBusinessImplementation(IRepository<Award> repository)
        {
            _repository = repository;
            _converter = new AwardConverter();
        }
        public AwardVO Create(AwardVO award)
        {
            var awardEntity = _converter.Parse(award);
            awardEntity = _repository.Create(awardEntity);
            return _converter.Parse(awardEntity);

        }
        public AwardVO Update(AwardVO award)
        {
            var awardEntity = _converter.Parse(award);
            awardEntity = _repository.Update(awardEntity);
            return _converter.Parse(awardEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<AwardVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public AwardVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }
     
    }
}
