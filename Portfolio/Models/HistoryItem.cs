namespace Portfolio.Models;

public class HistoryItem
{
    public string Full_Name { get; set; }
    public string Description { get; set; }
    public string HTML_URL { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
    public string Language { get; set; }
    public bool Fork { get; set; }
}