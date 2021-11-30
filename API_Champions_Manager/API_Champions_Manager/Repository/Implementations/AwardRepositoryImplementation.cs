using API_Champions_Manager.Model;
using API_Champions_Manager.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Champions_Manager.Repository.Implementations
{
    public class AwardRepositoryImplementation : IAwardRepository
    {
        private MySQLContext _context;
        public AwardRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Award Create(Award award)
        {
            try
            {
                _context.Add(award);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return award;
        }
        public void Delete(long id)
        {
            var result = _context.Awards.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Awards.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Award> FindAll()
        {
            return _context.Awards.ToList();
        }

        public Award FindById(long id)
        {
            return _context.Awards.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Award Update(Award award)
        {
            // We check if the person exists in the database
            // If it doesn't exist we return an empty person instance
            if (!Exists(award.Id)) return null;

            // Get the current status of the record in the database
            var result = _context.Awards.SingleOrDefault(p => p.Id.Equals(award.Id));
            if (result != null)
            {
                try
                {
                    // set changes and save
                    _context.Entry(result).CurrentValues.SetValues(award);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return award;
        }
        private bool Exists(long id)
        {
            return _context.Awards.Any(p => p.Id.Equals(id));
        }

        bool IAwardRepository.Exists(long id)
        {
            return _context.Awards.Any(p => p.Id.Equals(id));
        }
    }
}
