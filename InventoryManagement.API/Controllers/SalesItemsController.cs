﻿using InventoryManagement.Application.Queries.GetSaleItemById;
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
    }
}
