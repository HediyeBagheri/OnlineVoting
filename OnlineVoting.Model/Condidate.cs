using System.ComponentModel.DataAnnotations;

namespace OnlineVoting.Model
{
    public class Condidate
    {
        public Condidate()
        {
            Advisers = new HashSet<Adviser>();
            Votes = new HashSet<Vote>();
        }
        [Key]
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string Name { get; set; }

        [StringLength(64)]
        public string CompressName { get; set; }

        [Required, StringLength(128)]
        public string LastName { get; set; }

        [Required, StringLength(128)]
        public string City { get; set; }
        public ICollection<Adviser> Advisers { get; set; }
        public ICollection<Vote> Votes { get; set; }

    }
}