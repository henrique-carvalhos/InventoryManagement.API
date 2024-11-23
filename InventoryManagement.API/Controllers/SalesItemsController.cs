using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.API.Controllers
{
    [Route("api/salesItems")]
    [ApiController]
    public class SalesItemsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SalesItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
