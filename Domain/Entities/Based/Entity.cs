using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Based
{
    public class Entity
    {
        public long Id { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public long LastModifiedBy { get; set; }

        public DateTime LastModifiedOn { get; set; }
    }
}
