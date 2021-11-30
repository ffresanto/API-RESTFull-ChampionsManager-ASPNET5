using API_Champions_Manager.Model;
using API_Champions_Manager.Repository;
using API_Champions_Manager.Repository.Generic;
using System.Collections.Generic;
using System.Linq;

namespace API_Champions_Manager.Business.Implementations
{
    public class AwardSBusinessImplementation : IAwardBusiness
    {
        private readonly IRepository<Award> _repository;

        public AwardSBusinessImplementation(IRepository<Award> repository)
        {
            _repository = repository;
        }

        public Award Create(Award award)
        {
            return _repository.Create(award);
        }
        public Award Update(Award award)
        {
            return _repository.Update(award);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Award> FindAll()
        {
            return _repository.FindAll();
        }

        public Award FindById(long id)
        {
            return _repository.FindById(id);
        }
     
    }
}
