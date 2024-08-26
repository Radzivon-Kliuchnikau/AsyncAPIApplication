namespace AsyncAPIApplication.Dtos;

public class ListingStatus
{
   public string? StatusOfRequest { get; set; } 
   
   public string? EstimatedTimeToCompleteTheTask { get; set; }
   
   public string? ResourceURL { get; set; }
}