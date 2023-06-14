using OnlineVoting.Model.IdentityModels;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.DTOs
{
    public class VoteDTO
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CondidateId { get; set; }
        public int VotingId { get; set; }
    }
}
