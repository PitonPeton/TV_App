

namespace TV_App.Persistance.Models
{
	public class Genres
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Series> Series { get; set; }	
	}
}
