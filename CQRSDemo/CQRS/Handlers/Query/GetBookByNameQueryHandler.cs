using AutoMapper;
using CQRSDemo.CQRS.Queries.Request;
using CQRSDemo.CQRS.Queries.Response;
using CQRSDemo.Entities;
using CQRSDemo.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Handlers.Query
{
    public class GetBookByNameQueryHandler: IRequestHandler<GetBookByNameQueryRequest, GetBookByNameQueryResponse>
    {
        private readonly FakeService _bookService;
        private IMapper _mapper;
        public GetBookByNameQueryHandler(FakeService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public Task<GetBookByNameQueryResponse> Handle(GetBookByNameQueryRequest request, CancellationToken cancellationToken)
        {
            var book = _bookService.GetByName(request.Name);
            var response = _mapper.Map<GetBookByNameQueryResponse>(book);
            if (book == null)
                return null;

            return Task.FromResult(response);

        }
    }
}
