using AutoMapper;
using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Model;
using System.Linq;

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
            foreach (var ad in advisers)
            {
                var adv = repository.GetAll().Where(x => x.CondidateId == ad.CondidateId);
                if(adv.Count() < 2)
                {
                    repository.Add(ad);
                    var adviser = mapper.Map<Adviser>(new AdviserAddDTO());
                }
            }
            return true;
        }

        else
            return false;
    }

    public bool Update(int id, List<AdviserDTO> adviserDTOs)
    {
        if (adviserDTOs[0].CondidateId != id && adviserDTOs[1].CondidateId != id)
        {
            return false;
        }
        if (adviserDTOs[0].CondidateId == id)
        {
            var adv = mapper.Map<Adviser>(adviserDTOs[0]);
            repository.Update(id, adv);
        }
        if (adviserDTOs[1].CondidateId == id)
        {
            var adv = mapper.Map<Adviser>(adviserDTOs[1]);
            repository.UpdateSecIndex(id, adv);
        }
        return true;

    }
    public bool UpdateOneAdviser(int id,AdviserAddDTO adviserAddDTO)
    {
        if(adviserAddDTO is null)
        { 
            return false;
        }
        var adv = mapper.Map<Adviser>(adviserAddDTO);
        repository.UpdateOneAdviser(id, adv);
        return true;

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
