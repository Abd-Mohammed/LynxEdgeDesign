namespace LynxEdgeDesign.Data.Models;

public class Vehicle
{
	public int Id { get; set; }
	public string? Label { get; set; }
	public int? Count { get; set; } = null;
	public int? Capacity { get; set; } = null; 
}