using Application.Commands.BloodGroups;
using Application.Queries.BloodGroups;
using Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

        [HttpGet]
        public async Task<IList<BloodGroupDto>> Get()
        {
            return await Mediator.Send(new GetBloodGroupQuery());
        }
    }
}
