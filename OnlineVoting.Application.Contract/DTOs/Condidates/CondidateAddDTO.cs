using System.ComponentModel.DataAnnotations;

namespace OnlineVoting.Application.Contract.DTOs.Condidates
{
    public class CondidateAddDTO
    {
        [Required, StringLength(64)]
        public string Name { get; set; }

        [Required, StringLength(128)]
        public string LastName { get; set; }

        [Required, StringLength(128)]
        public string City { get; set; }
    }
}
