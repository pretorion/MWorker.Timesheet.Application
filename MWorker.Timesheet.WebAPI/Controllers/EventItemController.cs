using MediatR;
using Microsoft.AspNetCore.Mvc;
using MWorker.Timesheet.Application;
using System.Threading.Tasks;

namespace MWorker.Timesheet.WebAPI.Controllers
{
    [ApiController]
    public class EventItemController : ApiControllerBase
    {

        [HttpPost("event")]
        public async Task<int> Post(SaveEventQuery model)
        {
            return await Mediator.Send(model);
        }
    }
}