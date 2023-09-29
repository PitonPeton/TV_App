using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TV_App.Application.Repository;
using TV_App.Application.ViewModel;
using TV_App.Persistance;
using TV_App.Persistance.Models;

namespace TV_App.Application.Services
{
	internal class SeriesService
	{
		private readonly SeriesRepository _seriesRepository;

		public SeriesService(TV_AppContext context)
		{
			_seriesRepository = new(context);
		}

		public async Task Add(AddSeriesViewModel seriesViewModel)
		{
			Series series = new();
			series.Id = seriesViewModel.Id;
			series.Name = seriesViewModel.Name;
			series.Video = seriesViewModel.Video;
			series.Img = seriesViewModel.Img;
			series.ProductorId = seriesViewModel.ProductorId;
			series.GenreId = seriesViewModel.GenreId;
			series.Productor = seriesViewModel.Productor;
			series.Genre = seriesViewModel.Genre;

			await _seriesRepository.AddAsync(series);
		}
		
	}
}
