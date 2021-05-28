using CQRSDemo.CQRS.Commands.Request;
using CQRSDemo.CQRS.Handlers.Command;
using CQRSDemo.CQRS.Handlers.Query;
using CQRSDemo.CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllBooksQueryRequest();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateBookCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var query = new GetBookByNameQueryRequest{ Name = name};
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpDelete("{bookid}")]
        public async Task<IActionResult> Delete(Guid bookid)
        {
            var query = new DeleteBookCommandRequest{ BookId = bookid};
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
