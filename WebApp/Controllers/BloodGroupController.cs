using Application.Commands.BloodGroups;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Authorize]
    public class BloodGroupController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateBloodGroupCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
