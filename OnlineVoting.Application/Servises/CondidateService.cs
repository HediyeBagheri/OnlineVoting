using AutoMapper;
using Microsoft.Extensions.Options;
using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Application.Contract.IServices;
using OnlineVoting.InfraSturacture.IRepositories;
using OnlineVoting.InfraSturacture.Repositories;
using OnlineVoting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVoting.Application.Servises
{
    public class CondidateService : ICondidateService
    {
        private readonly ICondidateRepository repository;
        private readonly IMapper mapper;


        public CondidateService(ICondidateRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;

        }
        //TODO
        public void Add(CondidateAddDTO condidateAddDTO)
        {
             var condidate = mapper.Map<Condidate>(condidateAddDTO);
                 repository.Add(condidate);
        }

        public int Delete(int id)
        {
            return repository.Delete(id);
        }

        public List<Condidate> GetAll()
        {
            var condidates = repository.GetAll().ToList();
            return mapper.Map<List<Condidate>>(condidates);
        }
        
        public List<Condidate> Search(string keyWord)
        {
            var condidate = repository.Search(keyWord);
            return mapper.Map<List<Condidate>>(condidate);
        }

    }
}
