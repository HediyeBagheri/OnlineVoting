using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineVoting.Model.IdentityModels;

namespace OnlineVoting.Model
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int CondidateId { get; set; }
        public Condidate Condidate { get;}
        public int VotingId { get; set; }
        public Voting Voting { get; set; }
    }
}
