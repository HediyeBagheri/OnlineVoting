using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Model;

public interface IAdviserService
{
    bool Add(List<AdviserAddDTO> adviserAddDTOs);
    bool Update(int id, List<AdviserDTO> adviserDTOs);
    bool UpdateOneAdviser(int id, AdviserAddDTO adviserAddDTO);
    public int Delete(int id);
    List<Adviser> GetAll();
    List<Adviser> Search(string keyWord);
}
