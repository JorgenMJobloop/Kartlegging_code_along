/// <summary>
/// Main movies model
/// </summary>
public class Movies
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public List<string> Cast { get; set; } = new List<string>();
    public double Runtime { get; set; }
    public string Rating { get; set; } = string.Empty;
    public int ReleaseYear { get; set; }
    public List<string> Writers { get; set; } = new List<string>();
}