namespace SSLBooking.Models;

public class NewsItem
{
    public long NewsItemId { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Message { get; set; } = String.Empty;
    public string? Message2 { get; set; }

    public string Type { get; set; } = "yellow";
}