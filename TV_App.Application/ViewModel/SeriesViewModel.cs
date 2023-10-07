using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TV_App.Persistance.Models;

namespace TV_App.Application.ViewModel
{
	internal class SeriesViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Video { get; set; }
		public string Img { get; set; }
		public int ProductorId { get; set; }
		public int GenreId { get; set; }

	}
}
