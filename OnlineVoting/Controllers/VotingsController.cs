using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineVoting.Application.Contract.DTOs.Voting;

[Route("api/[controller]")]
[ApiController]
public class VotingsController : ControllerBase
{
    private readonly IVotingService VotingService;

    public VotingsController(IVotingService votingService)
    {
        this.VotingService = votingService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(VotingService.GetAll());
    }

    [Authorize("SupportPolicy")]
    [HttpPost]
    public IActionResult Add([FromForm] VotingAddDTO votingService)
    {
        VotingService.Add(votingService);
        return Created("", votingService);

    }

    [Authorize("SupportPolicy")]
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        return Ok(VotingService.Delete(id));
    }

}
