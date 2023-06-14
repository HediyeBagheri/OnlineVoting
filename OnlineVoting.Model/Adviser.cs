using System.ComponentModel.DataAnnotations;

namespace OnlineVoting.Model
{
    public class Adviser
    {

        [Key]
        public int Id { get; set; }

        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required, StringLength(128)]
        public string LastName { get; set; }
        public int CondidateId { get; set; }
        public Condidate Condidate { get; set; }
    }
}
