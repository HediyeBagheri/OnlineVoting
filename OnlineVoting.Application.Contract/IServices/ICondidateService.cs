using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.IServices
{
    public interface ICondidateService
    {
        void Add(CondidateAddDTO condidateAddDTO);
        public int Delete(int id);
        List<Condidate> GetAll();
        List<Condidate> Search(string keyWord);
    }
}
