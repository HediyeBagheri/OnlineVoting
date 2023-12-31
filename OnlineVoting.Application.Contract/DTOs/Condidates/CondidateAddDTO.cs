﻿using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.DTOs.Condidates
{
    public class CondidateAddDTO
    {
        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required, StringLength(128)]
        public string LastName { get; set; }

        [Required, StringLength(128)]
        public string City { get; set; }
        public ICollection<AdviserAddDTO> Advisers { get; set; }
    }
}
