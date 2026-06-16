using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TVShowsController : ControllerBase
{
    private readonly List<TVShows> _tvShows = new List<TVShows>()
    {
        new TVShows
        {
            Id = 1,
            Title = "The Sopranos",
            Creator = "David Chase",
            NumberOfSeasons = 6,
            EpisodeDescription = [
                new Episode
                {
                    Title = "Made in Amercia",
                    Cast = ["James Gandofini", "Edie Falco"],
                    Description = "Tony Soprano takes some time to relax after the war with the New York family is finally over",
                    Runtime = 55
                }]
        }
    };

    [HttpGet]
    public IActionResult GetTvShow()
    {
        if (!ModelState.IsValid)
        {
            return NotFound();
        }
        return Ok(_tvShows);
    }
}