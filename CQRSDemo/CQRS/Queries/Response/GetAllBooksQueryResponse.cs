using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Queries.Response
{
    public class GetAllBooksQueryResponse
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Quantity { get; set; }
    }
}
