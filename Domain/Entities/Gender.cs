using Domain.Entities.Based;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gender : Entity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
