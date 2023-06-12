using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineVoting.Application.Contract.DTOs.Advisers;

namespace OnlineVoting.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisersController : ControllerBase
    {
        private readonly IAdviserService AdviserService;

        public AdvisersController(IAdviserService adviserService)
        {
            this.AdviserService = adviserService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(AdviserService.GetAll());
        }

        [Authorize("SupportPolicy")]
        [HttpPost]
        public IActionResult Add([FromForm] AdviserAddDTO adviserService)
        {
            AdviserService.Add(adviserService);
            return Created("", adviserService);

        }

        [Authorize("SupportPolicy")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(AdviserService.Delete(id));
        }

        [HttpGet("{keyWord}")]
        public IActionResult Search(string keyWord)
        {
            return Ok(AdviserService.Search(keyWord));
        }
    }
}
