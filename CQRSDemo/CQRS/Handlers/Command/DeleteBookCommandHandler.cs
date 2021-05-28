using CQRSDemo.CQRS.Commands.Request;
using CQRSDemo.CQRS.Commands.Response;
using CQRSDemo.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Handlers.Command
{
    public class DeleteBookCommandHandler: IRequestHandler<DeleteBookCommandRequest, DeleteBookCommandResponse>
    {
        private readonly FakeService _bookService;
        public DeleteBookCommandHandler(FakeService bookService)
        {
            _bookService = bookService;
        }

        public Task<DeleteBookCommandResponse> Handle(DeleteBookCommandRequest request, CancellationToken cancellationToken)
        {
            _bookService.Delete(request.BookId);
            return Task.FromResult(new DeleteBookCommandResponse { IsSuccess = true});
        }
    }
}
