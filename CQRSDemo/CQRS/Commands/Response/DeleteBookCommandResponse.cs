using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Commands.Response
{
    public class DeleteBookCommandResponse
    {
        public bool IsSuccess { get; set; }
    }
}
