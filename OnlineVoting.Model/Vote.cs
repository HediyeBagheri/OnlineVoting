using OnlineVoting.Model.IdentityModels;
using System.ComponentModel.DataAnnotations;

namespace OnlineVoting.Model
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int CondidateId { get; set; }
        public Condidate Condidate { get; }
        public int VotingId { get; set; }
        public Voting Voting { get; set; }
    }
}
