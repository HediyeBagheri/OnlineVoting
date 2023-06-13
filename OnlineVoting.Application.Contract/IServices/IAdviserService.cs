using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Model;

public interface IAdviserService
{
    bool Add(List<AdviserAddDTO> adviserAddDTOs);
    public int Delete(int id);
    List<Adviser> GetAll();
    List<Adviser> Search(string keyWord);
}
