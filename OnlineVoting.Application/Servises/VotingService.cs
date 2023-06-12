using AutoMapper;
using OnlineVoting.Application.Contract.DTOs.Voting;
using OnlineVoting.Model;

public class VotingService : IVotingService
{
    private readonly IVotingRepository repository;
    private readonly IMapper mapper;


    public VotingService(IVotingRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;

    }
    public void Add(VotingAddDTO votingAddDTO)
    {
        var voting = mapper.Map<Voting>(votingAddDTO);
        repository.Add(voting);
    }

    public int Delete(int id)
    {
        return repository.Delete(id);
    }

    public List<Voting> GetAll()
    {
        var votings = repository.GetAll().ToList();
        return mapper.Map<List<Voting>>(votings);
    }

}
