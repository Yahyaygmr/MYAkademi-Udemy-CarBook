﻿using CarBook.Application.Features.Mediator.Results.AppUserResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.AppUserQueries
{
    public class GetCheckApUserQuery : IRequest<GetCheckApUserQueryResult>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
