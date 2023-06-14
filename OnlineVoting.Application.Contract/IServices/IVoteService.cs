using OnlineVoting.Application.Contract.DTOs;

public interface IVoteService
{
    List<VoteDTO> GetAll();
}
