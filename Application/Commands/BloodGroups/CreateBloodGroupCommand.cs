using MediatR;

namespace Application.Commands.BloodGroups
{
    public class CreateBloodGroupCommand : IRequest<int>
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
