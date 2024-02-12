using System.Security.Cryptography;

namespace LynxEdgeDesign.Data.Models;

public class Profile
{
	public int Id { get; set; }
	public string Name { get; set; }
	public DateTime CreatedDate { get; set; }
	public DateTime StarDate { get; set; }
	public DateTime EndDate { get; set; }
	public int OnOffLoadTime { get; set; }
	public int SlackTime { get; set; }
	public List<Vehicle> Vehicles { get; set; } = [];

	public string Class { get; set; } = string.Empty;

}