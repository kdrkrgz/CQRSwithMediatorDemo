using CQRSDemo.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Commands.Request
{
    public class CreateBookCommandRequest: IRequest<CreateBookCommandResponse>
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Quantity { get; set; }
    }
}
