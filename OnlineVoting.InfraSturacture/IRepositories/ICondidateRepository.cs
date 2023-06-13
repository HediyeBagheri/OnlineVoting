using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.InfraSturacture.IRepositories
{
    public interface ICondidateRepository
    {
        IQueryable<Condidate> GetAll();
        bool Add(Condidate condidate);
        int Delete(int id);
        IQueryable<Condidate> Search(string keyword);
    }
}
