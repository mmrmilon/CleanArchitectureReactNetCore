using Domain.Entities.Based;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Donor : Entity
    {
        public string Name { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public DateTime? LastDonationOn { get; set; }

        public Guid GenderId { get; set; }

        public Guid BloodGroupId { get; set; }


        public Gender Gender { get; set; } = null!;
        public BloodGroup BloodGroup { get; set; } = null!;
    }
}
