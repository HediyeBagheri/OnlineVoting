using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Model;

namespace OnlineVoting.Application.Contract.IServices
{
    public interface ICondidateService
    {
        bool Add(CondidateAddDTO condidateAddDTO);
        public int Delete(int id);
        List<Condidate> GetAll();
        List<Condidate> Search(string keyWord);
    }
}
