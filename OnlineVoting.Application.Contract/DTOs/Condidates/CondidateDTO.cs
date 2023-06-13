using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.DTOs.Condidates
{
    public class CondidateDTO
    {
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string Name { get; set; }

        [Required, StringLength(128)]
        public string LastName { get; set; }

        [Required, StringLength(128)]
        public string City { get; set; }
    }
}
