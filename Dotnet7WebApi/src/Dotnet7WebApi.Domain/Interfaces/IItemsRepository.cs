using Dotnet7WebApi.Domain.Model;

namespace Dotnet7WebApi.Domain.Interfaces
{
    public interface IItemsRepository
    {
        public List<Item> GetItems();
    }
}
