using Domain.Entities.Based;

namespace Domain.Entities
{
    public class BloodGroup : Entity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
