using Microsoft.EntityFrameworkCore;
using OnlineVoting.InfraSturacture.Context;
using OnlineVoting.Model;
using System.Security.Cryptography.X509Certificates;

namespace OnlineVoting.InfraSturacture.Repositories
{
    public class AdviserRepository : IAdviserRepository
    {
        private readonly OnlineVotingContext context;

        public AdviserRepository(OnlineVotingContext context)
        {
            this.context = context;
        }

        public IQueryable<Adviser> GetAll()
        {
            return context.Adviser;
        }

        public bool Add(Adviser adviser)
        {
            if (adviser != null)
            {
                    context.Adviser.Add(adviser);
                    context.SaveChanges();
                return true;
            }
            else
                return false;
            
        }

        public bool Update(int id, Adviser adviser)
        {
            if (adviser is null)
                return false;
            else
            {
                var adv = context.Adviser.First(x => x.Id == id);
                if (adv != null)
                {
                    adv.Name = adviser.Name;
                    adv.LastName = adviser.LastName;
                }
                context.Adviser.Update(adv);
                context.SaveChanges();
                return true;
            }
        }

        public int Delete(int id)
        {
            var adviser = context.Adviser.First(x => x.Id == id);
            context.Adviser.Remove(adviser);
            return context.SaveChanges();
        }

        public IQueryable<Adviser> Search(string keyword)
        {
            return context.Adviser.Where(p => p.Name.Contains(keyword));
        }
    }
}
