using OnlineVoting.Model;

public interface IVotingRepository
{
    IQueryable<Voting> GetAll();
    int Add(Voting voting);
    int Delete(int id);
}
