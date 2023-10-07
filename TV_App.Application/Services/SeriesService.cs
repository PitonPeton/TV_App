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

			await _seriesRepository.AddAsync(series);
		}
		public async Task Update(AddSeriesViewModel seriesViewModel)
		{
			Series series = new();
			series.Id = seriesViewModel.Id;
			series.Name = seriesViewModel.Name;
			series.Video = seriesViewModel.Video;
			series.Img = seriesViewModel.Img;
			series.ProductorId = seriesViewModel.ProductorId;
			series.GenreId = seriesViewModel.GenreId;

			await _seriesRepository.AddAsync(series);
		}
		public async Task Delete(int id)
		{
			var series = await _seriesRepository.GetByIdAsync(id);
			await _seriesRepository.DeleteAsync(series);
		}
		public async Task<AddSeriesViewModel> GetByIdAddViewModel(int id)
		{
			var series = await _seriesRepository.GetByIdAsync(id);
			AddSeriesViewModel viewModel = new();
			viewModel.Id = series.Id;
			viewModel.Name = series.Name;
			viewModel.Video = series.Video;
			viewModel.Img = series.Img;
			viewModel.ProductorId = series.ProductorId;
			viewModel.GenreId = series.GenreId;

			return viewModel;
		}
		public async Task<List<SeriesViewModel>> GetViewModel()
		{
			var list = await _seriesRepository.GetAllAsync();
			return list.Select(series => new SeriesViewModel
			{
				Id = series.Id,
				Name = series.Name,
				Video = series.Video,
				Img = series.Img,
				ProductorId = series.ProductorId,
				GenreId = series.GenreId,

			}).ToList();
		}
	}
}
