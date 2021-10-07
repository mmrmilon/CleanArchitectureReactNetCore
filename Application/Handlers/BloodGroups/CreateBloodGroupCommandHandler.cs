using Application.Commands.BloodGroups;
using Application.Common;
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
        public readonly IApplicationDbContext context;

        public CreateBloodGroupCommandHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Handle(CreateBloodGroupCommand request, CancellationToken cancellationToken)
        {
            var bloodGroup = new BloodGroup
            {
                Title = request.Title,
                Description = request.Description
            };
            context.BloodGroups.Add(bloodGroup);
            await context.SaveChangesAsync(cancellationToken);
            return bloodGroup.Id;
        }
    }
}
