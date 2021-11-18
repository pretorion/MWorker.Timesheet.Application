using MediatR;
using Microsoft.AspNetCore.Mvc;
using MWorker.Timesheet.Application;
using MWorker.Timesheet.Application.Events.EventList;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MWorker.Timesheet.WebAPI.Controllers
{
    [ApiController]
    public class EventListController : ApiControllerBase
    {
        [HttpGet("events")]
        public async Task<IEnumerable<EventListModel>> Get()
        {
            return await Mediator.Send(new EventListQuery());
        }
        [HttpGet("eventsByHour")]
        public async Task<IEnumerable<EventListModel>> ByHour()
        {
            throw new NotImplementedException();
        }
    }
}