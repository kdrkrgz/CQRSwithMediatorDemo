using CQRSDemo.CQRS.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Queries.Request
{
    public class GetAllBooksQueryRequest: IRequest<List<GetAllBooksQueryResponse>>
    {
    }
}
