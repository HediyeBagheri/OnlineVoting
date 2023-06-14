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

        //[Authorize("SupportPolicy")]
        [HttpPost]
        public IActionResult Add(List<AdviserAddDTO> adviserDtos)
        {
            return Ok(AdviserService.Add(adviserDtos));
           // return Created("", adviserDtos);

        }

        [HttpPut]
        public IActionResult Update(int id, List<AdviserDTO> adviserDTOs)
        {
            return Ok(AdviserService.Update(id, adviserDTOs));
        }

        [HttpPatch]
        public IActionResult UpdateOneAdviser(int id, AdviserAddDTO adviserAddDTO)
        {
            return Ok(AdviserService.UpdateOneAdviser(id, adviserAddDTO));
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
