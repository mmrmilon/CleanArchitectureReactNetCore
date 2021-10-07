using Application.Common;
using Application.Queries.BloodGroups;
using Application.ViewModels;
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
        public GetBloodGroupQueryHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IList<BloodGroupDto>> Handle(GetBloodGroupQuery request, CancellationToken cancellationToken)
        {
            var result = await context.BloodGroups.ToListAsync();
            return result.Select(x => new BloodGroupDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            }).ToList();
        } 
    }
}
