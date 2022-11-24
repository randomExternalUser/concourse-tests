using Dotnet7WebApi.Domain.Interfaces;
using Dotnet7WebApi.Domain.Model;

namespace Dotnet7WebApi.Infrastructure.DataAccess.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly ApplicationDbContext _db;

        public ItemsRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Item> GetItems()
        {
            return _db.Items;
        }
    }
}
