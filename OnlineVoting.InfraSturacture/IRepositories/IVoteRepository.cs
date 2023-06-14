using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OnlineVoting.InfraSturacture.IRepositories
{
    public interface IVoteRepository
    {
        public Task<IQueryable<Vote>> GetVote();
    }
}
