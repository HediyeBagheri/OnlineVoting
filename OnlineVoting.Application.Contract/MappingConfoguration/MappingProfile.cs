using AutoMapper;
using OnlineVoting.Application.Contract.DTOs.Advisers;
using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Application.Contract.DTOs.Voting;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Contract.MappingConfoguration
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Condidate, CondidateDTO>();
            CreateMap<CondidateDTO, Condidate>();
            CreateMap<CondidateAddDTO, Condidate>();

            CreateMap<Adviser, AdviserDTO>();
            CreateMap<AdviserDTO, Adviser>();
            CreateMap<AdviserAddDTO, Adviser>();

            CreateMap<Voting, VotingDTO>();
            CreateMap<VotingDTO, Voting>();
            CreateMap<VotingAddDTO, Voting>();
        }
    }
}
