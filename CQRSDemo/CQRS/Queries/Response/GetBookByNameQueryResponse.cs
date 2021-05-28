﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Queries.Response
{
    public class GetBookByNameQueryResponse
    {
        public Guid BookId { get; set; }
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Quantity { get; set; }
    }
}
