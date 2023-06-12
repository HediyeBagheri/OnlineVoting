using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
