public class TVShows
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int NumberOfSeasons { get; set; }
    public string Creator { get; set; } = string.Empty;
    public List<Episode> EpisodeDescription { get; set; } = new List<Episode>();
}