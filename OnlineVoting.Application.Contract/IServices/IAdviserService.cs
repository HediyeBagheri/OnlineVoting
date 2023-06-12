using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Model;

public interface IAdviserService
{
    void Add(AdviserAddDTO adviserAddDTO);
    public int Delete(int id);
    List<Adviser> GetAll();
    List<Adviser> Search(string keyWord);
}
