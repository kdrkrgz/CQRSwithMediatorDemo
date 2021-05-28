using CQRSDemo.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Commands.Request
{
    public class DeleteBookCommandRequest: IRequest<DeleteBookCommandResponse>
    {
        public Guid BookId { get; set; }
    }
}
