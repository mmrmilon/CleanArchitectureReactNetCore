using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common
{
    public interface IApplicationDbContext
    {
        DbSet<BloodGroup> BloodGroups { get; set; }

        DbSet<Donor> Donors { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
