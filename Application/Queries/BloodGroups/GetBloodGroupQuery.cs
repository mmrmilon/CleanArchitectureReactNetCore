using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.BloodGroups
{
    public class GetBloodGroupQuery : IRequest<IList<BloodGroupDto>>
    {
    }
}
