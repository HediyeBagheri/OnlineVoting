using AutoMapper;
using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Model;

public class AdviserService : IAdviserService
{
    private readonly IAdviserRepository repository;
    private readonly IMapper mapper;


    public AdviserService(IAdviserRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;

    }
    public bool Add(List<AdviserAddDTO> adviserAddDTOs)
    {
         
        if (adviserAddDTOs != null && adviserAddDTOs.Count() < 3)
        {
            var advisers = mapper.Map<List<Adviser>>(adviserAddDTOs);
           // adviserAddDTOs.ToList().ForEach(x => repository.Add(adviser));
           foreach(var ad in advisers)
           {
               repository.Add(ad);
           }
            return true;
        }
        else
            return false;
    }

    public int Delete(int id)
    {
        return repository.Delete(id);
    }

    public List<Adviser> GetAll()
    {
        var advisers = repository.GetAll().ToList();
        return mapper.Map<List<Adviser>>(advisers);
    }

    public List<Adviser> Search(string keyWord)
    {
        var adviser = repository.Search(keyWord);
        return mapper.Map<List<Adviser>>(adviser);
    }


}
