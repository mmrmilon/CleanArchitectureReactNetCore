using Domain.Common.Enums;
using Domain.Entities.Based;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Donor : Entity
    {
        public string Name { get; set; }

        public Gender GenderId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime LastDonationOn { get; set; }

        public int BloodGroupId { get; set; }

        public BloodGroup BloodGroup { get; set; }
    }
}
