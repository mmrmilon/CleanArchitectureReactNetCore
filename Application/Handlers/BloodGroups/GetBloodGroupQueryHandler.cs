using Application.Common;
using Application.Queries.BloodGroups;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.BloodGroups
{
    public class GetBloodGroupQueryHandler : IRequestHandler<GetBloodGroupQuery, IList<BloodGroupDto>>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;
        public GetBloodGroupQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IList<BloodGroupDto>> Handle(GetBloodGroupQuery request, CancellationToken cancellationToken)
        {
            var result = await context.BloodGroups.ToListAsync();
            return mapper.Map<IList<BloodGroupDto>>(result);
        } 
    }
}
