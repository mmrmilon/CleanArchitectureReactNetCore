using Application.Commands.BloodGroups;
using Application.Common;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.BloodGroups
{
    public class CreateBloodGroupCommandHandler : IRequestHandler<CreateBloodGroupCommand, int>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;

        public CreateBloodGroupCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> Handle(CreateBloodGroupCommand request, CancellationToken cancellationToken)
        {
            var bloodGroup = mapper.Map<BloodGroup>(request);
            
            context.BloodGroups.Add(bloodGroup);
            await context.SaveChangesAsync(cancellationToken);
            
            return bloodGroup.Id;
        }
    }
}
