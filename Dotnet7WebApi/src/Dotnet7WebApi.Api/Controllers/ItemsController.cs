using Dotnet7WebApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet7WebApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _itemsRepository.GetItems();
            return Ok(items);
        }
    }
}
