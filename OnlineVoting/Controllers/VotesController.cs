using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineVoting.Application.Servises;
using OnlineVoting.InfraSturacture.IRepositories;
using OnlineVoting.InfraSturacture.Repositories;

namespace OnlineVoting.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotesController : ControllerBase
    {
        private readonly IVoteService voteServ;
        public VotesController(IVoteService voteServ)
        {
            this.voteServ = voteServ;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(voteServ.GetAll());
        }
    }
}
