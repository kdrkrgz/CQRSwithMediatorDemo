using AutoMapper;
using CQRSDemo.CQRS.Queries.Request;
using CQRSDemo.CQRS.Queries.Response;
using CQRSDemo.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Handlers.Query
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQueryRequest, List<GetAllBooksQueryResponse>>
    {
        private readonly FakeService _bookService;
        private readonly IMapper _mapper;
        public GetAllBooksQueryHandler(FakeService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        Task<List<GetAllBooksQueryResponse>> IRequestHandler<GetAllBooksQueryRequest, List<GetAllBooksQueryResponse>>.Handle(GetAllBooksQueryRequest request, CancellationToken cancellationToken)
        {
            var books = _bookService.Books.ToList();
            var response = _mapper.Map<List<GetAllBooksQueryResponse>>(books);
            return Task.FromResult(response);
        }
    }
}
