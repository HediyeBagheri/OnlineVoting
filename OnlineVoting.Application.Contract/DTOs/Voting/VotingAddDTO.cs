using System.ComponentModel.DataAnnotations;

namespace OnlineVoting.Application.Contract.DTOs.Voting
{
    public class VotingAddDTO
    {
        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
    }
}
