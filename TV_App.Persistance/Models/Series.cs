

namespace TV_App.Persistance.Models
{
	public class Series
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Video { get; set; }
		public string Img { get; set; }
		public int ProductorId { get; set; }
		public int GenreId { get; set; }

		public Productors Productor { get; set; }
		public Genres Genre { get; set; }

	}
}
