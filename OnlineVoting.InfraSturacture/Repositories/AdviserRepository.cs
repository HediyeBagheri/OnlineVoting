using OnlineVoting.InfraSturacture.Context;
using OnlineVoting.Model;

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

        public int Add(Adviser adviser)
        {
            context.Adviser.Add(adviser);
            return context.SaveChanges();
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
