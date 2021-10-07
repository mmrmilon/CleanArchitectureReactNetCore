using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Based
{
    public class Entity
    {
        public long Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedOn { get; set; }
    }
}
