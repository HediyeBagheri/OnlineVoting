using OnlineVoting.InfraSturacture.Context;
using OnlineVoting.Model;

public class VotingRepository : IVotingRepository
{
    private readonly OnlineVotingContext context;

    public VotingRepository(OnlineVotingContext context)
    {
        this.context = context;
    }

    public IQueryable<Voting> GetAll()
    {
        return context.Voting;
    }

    public int Add(Voting voting)
    {
        context.Voting.Add(voting);
        return context.SaveChanges();
    }

    public int Delete(int id)
    {
        var voting = context.Voting.First(x => x.Id == id);
        context.Voting.Remove(voting);
        return context.SaveChanges();
    }

}
