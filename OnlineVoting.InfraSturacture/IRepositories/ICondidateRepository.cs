using OnlineVoting.Model;

namespace OnlineVoting.InfraSturacture.IRepositories
{
    public interface ICondidateRepository
    {
        IQueryable<Condidate> GetAll();
        bool Add(Condidate condidate);
        int Delete(int id);
        IQueryable<Condidate> Search(string keyword);
    }
}
