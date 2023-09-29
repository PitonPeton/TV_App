

using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TV_App.Persistance;
using TV_App.Persistance.Models;

namespace TV_App.Application.Repository
{
	public class SeriesRepository
	{
		private readonly TV_AppContext dbcontext;

		public SeriesRepository(TV_AppContext tV_AppContext)
		{
			dbcontext = tV_AppContext;
		}
		public async Task AddAsync(Series series)
		{
			await dbcontext.Set<Series>().AddAsync(series);
			await dbcontext.SaveChangesAsync();
		}
		public async Task UpdateAsync(Series series)
		{
			dbcontext.Entry(series).State = EntityState.Modified;
			await dbcontext.SaveChangesAsync();
		}
		public async Task DeleteAsync(Series series)
		{
			dbcontext.Set<Series>().Remove(series);
			await dbcontext.SaveChangesAsync();
		}
		public async Task<List<Series>> GetAllAsync()
		{
			return await dbcontext.Set<Series>().ToListAsync();
		}
		public async Task<Series> GetByIdAsync(int id)
		{
			return await dbcontext.Set<Series>().FindAsync(id);
		}
	}
}
