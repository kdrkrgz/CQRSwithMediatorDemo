using AutoMapper;
using CQRSDemo.CQRS.Commands.Request;
using CQRSDemo.CQRS.Queries.Response;
using CQRSDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.MappingProfiles
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            // source to domain
            CreateMap<Book, GetAllBooksQueryResponse>();
            CreateMap<Book, GetBookByNameQueryResponse>();

            // domain to source
            CreateMap<CreateBookCommandRequest, Book>();
        }
    }
}
