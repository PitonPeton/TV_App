

namespace TV_App.Persistance.Models
{
	public class Productors
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<Series> Series { get; set; }
	}
}
