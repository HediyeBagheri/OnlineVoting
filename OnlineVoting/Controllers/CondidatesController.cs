using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Application.Contract.IServices;

namespace OnlineVoting.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondidatesController : ControllerBase
    {
        private readonly ICondidateService CondidateService;

        public CondidatesController(ICondidateService CondidateService)
        {
            this.CondidateService = CondidateService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(CondidateService.GetAll());
        }
        //[Authorize("SupportPolicy")]
        [HttpPost]
        public IActionResult Add([FromForm] CondidateAddDTO condidateAddDTO)
        {
            CondidateService.Add(condidateAddDTO);
            return Created("", condidateAddDTO);

        }

        //[Authorize("SupportPolicy")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(CondidateService.Delete(id));
        }

        [HttpGet("{keyWord}")]
        public IActionResult Search(string keyWord)
        {
            return Ok(CondidateService.Search(keyWord));
        }
    }
}
