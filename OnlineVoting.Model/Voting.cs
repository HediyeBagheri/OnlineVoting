using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Model
{
    public class Voting
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
        private DateTime endTime;

        public DateTime EndTime
        {
            get { return endTime; }
            private set { endTime = StartTime.AddMinutes(3); }
        }
        public ICollection<Vote> Votes { get; set; }
    }
}
