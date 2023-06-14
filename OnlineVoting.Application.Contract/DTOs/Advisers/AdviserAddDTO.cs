using System.ComponentModel.DataAnnotations;

namespace OnlineVoting.Application.Contract.DTOs.Advisers
{
    public class AdviserAddDTO
    {
        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required, StringLength(128)]
        public string LastName { get; set; }
        public int CondidateId { get; set; }
    }
}
