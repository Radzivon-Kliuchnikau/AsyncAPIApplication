namespace AsyncAPIApplication.Models;

public class ListOfRequests
{
    public int Id { get; set; }
    
    public string? RequestBody { get; set; }
    
    public string? EstimatedTimeToCompleteTheTask { get; set; }
    
    public string? StatusOfRequest { get; set; }

    public string RequestId { get; set; } = Guid.NewGuid().ToString();
}