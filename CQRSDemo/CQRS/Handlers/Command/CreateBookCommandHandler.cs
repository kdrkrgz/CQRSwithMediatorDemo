using AutoMapper;
using CQRSDemo.CQRS.Commands.Request;
using CQRSDemo.CQRS.Commands.Response;
using CQRSDemo.Entities;
using CQRSDemo.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Handlers.Command
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandRequest, CreateBookCommandResponse>
    {
        private readonly FakeService _bookService;
        private IMapper _mapper;
        public CreateBookCommandHandler(FakeService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public Task<CreateBookCommandResponse> Handle(CreateBookCommandRequest request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request);
            book.BookId = Guid.NewGuid();
            book.LibraryId = 2;
            _bookService.Add(book);

            return Task.FromResult(new CreateBookCommandResponse { IsSuccess = true });
        }
    }
}
