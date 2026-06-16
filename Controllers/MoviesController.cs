using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    // configuring our datamodel as a readonly field
    private readonly List<Movies> _movies = new List<Movies>()
    {
        new Movies
        {
            Id = 1,
            Title = "Die Hard",
            Genre = "Action",
            Description = "John McClane fights his way through a sky scraper when he should be at home celebrating Christmas",
            Director = "John McTiernan",
            Cast = ["Bruce Willis", "Alan Rickman", "Bonnie Bedelia", "Reginald VelJohnson", "William Atherton"],
            Runtime = 132.0,
            Rating = "R",
            ReleaseYear = 1988,
            Writers = ["Jeb Stuart", "Steven E. de Souza"]
        }
    };

    [HttpGet]
    public IActionResult GetMovie()
    {
        if (!ModelState.IsValid)
        {
            return NotFound();
        }
        return Ok(_movies);
    }
}