using InventoryManagement.Application.Commands.InsertSaleItem;
using InventoryManagement.Application.Queries.GetAllSaleItem;
using InventoryManagement.Application.Queries.GetSaleItemById;
using MediatR;
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

        [HttpGet]
        public async Task<IActionResult> GetAll(string search = "")
        {
            var query = new GetAllSaleItemQuery(search);

            var result = await _mediator.Send(query);

            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetSaleItemByIdQuery(id);

            var result = await _mediator.Send(query);

            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InsertSaleItemCommand command)
        {
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, command);
        }
    }
}
