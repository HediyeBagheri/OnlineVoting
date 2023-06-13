using OnlineVoting.InfraSturacture.Context;
using OnlineVoting.InfraSturacture.IRepositories;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.InfraSturacture.Repositories
{
    public class CondidateRepository : ICondidateRepository
    {
        private readonly OnlineVotingContext context;

        public CondidateRepository(OnlineVotingContext context)
        {
            this.context = context;
        }

        public IQueryable<Condidate> GetAll()
        {
            return context.Condidate;
        }

        public bool Add(Condidate condidate)
        {
            if(condidate is not null)
            {
                condidate.CompressName = condidate.Name;
                context.Condidate.Add(condidate);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public int Delete(int id)
        {
            var condidate = context.Condidate.First(x => x.Id == id);
            context.Condidate.Remove(condidate);
            return context.SaveChanges();
        }

        public IQueryable<Condidate> Search(string keyword)
        {
            return context.Condidate.Where(p => p.Name.Contains(keyword));
        }

        
    }
}
