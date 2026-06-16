using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    // configuring our datamodel as a private field
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

    [HttpPost]
    public IActionResult CreateEntry([FromBody] Movies movie)
    {
        if (movie is null)
        {
            return StatusCode(201);
        }
        var _movie = new Movies
        {
            Id = movie.Id,
            Title = movie.Title,
            Genre = movie.Genre,
            Description = movie.Description,
            Director = movie.Director,
            Cast = movie.Cast,
            Runtime = movie.Runtime,
            Rating = movie.Rating,
            ReleaseYear = movie.ReleaseYear,
            Writers = movie.Writers
        };

        _movies.Add(_movie);

        return CreatedAtAction(nameof(CreateEntry), new { Id = movie.Id }
        , _movie);
    }
}