using Microsoft.Data.SqlClient;
using OnlineVoting.InfraSturacture.Context;
using OnlineVoting.InfraSturacture.IRepositories;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Dapper;

namespace OnlineVoting.InfraSturacture.Repositories
{
    public class VoteRepository : IVoteRepository
    {
        private readonly DapperContext _context;
        public VoteRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IQueryable<Vote>> GetVote()
        {
            var query = "SELECT * FROM Vote";
            using (var connection = _context.CreateConnection())
            {
               var vote = await connection.QueryAsync<Vote>(query);
               return vote.AsQueryable();
            }
        }
    }
}
