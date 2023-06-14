using AutoMapper;
using OnlineVoting.Application.Contract.DTOs;
using OnlineVoting.Application.Contract.DTOs.Voting;
using OnlineVoting.InfraSturacture.IRepositories;
using OnlineVoting.Model;

public class VoteService : IVoteService
{
    private readonly IVoteRepository repository;
    private readonly IMapper mapper;


    public VoteService(IVoteRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;

    }
    public List<VoteDTO> GetAll()
    {
        var votes = repository.GetVote();
        return votes.Result.Select(x => mapper.Map<VoteDTO>(x)).ToList();
    }

    
}
