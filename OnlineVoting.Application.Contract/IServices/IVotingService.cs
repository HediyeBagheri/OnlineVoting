using OnlineVoting.Application.Contract.DTOs.Voting;
using OnlineVoting.Model;

public interface IVotingService
{
    void Add(VotingAddDTO votingAddDTO);
    public int Delete(int id);
    List<Voting> GetAll();
}
