public class Episode
{
    public string Title { get; set; } = string.Empty;
    public List<string> Cast { get; set; } = new List<string>();
    public string Description { get; set; } = string.Empty;
    public double Runtime { get; set; }
}