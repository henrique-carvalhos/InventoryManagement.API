using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.API.Properties
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
