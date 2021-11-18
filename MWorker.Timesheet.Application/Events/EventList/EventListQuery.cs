using MediatR;
using MWorker.Timesheet.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MWorker.Timesheet.Application.Events.EventList
{
    public class EventListQuery : IRequest<List<EventListModel>>
    {
    }

    public class EventListQueryHandler : IRequestHandler<EventListQuery, List<EventListModel>>
    {
        private readonly IApplicationDbContext _context;

        public EventListQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<EventListModel>> Handle(EventListQuery request, CancellationToken cancellationToken)
        {
            return _context.Events.Select(s=>new EventListModel {
            Date = s.Date,
            Name = s.Name,
            Price = s.Price,
            Quantity = s.Quantity,
            Total = s.Price * s.Quantity,
            IsExpense = s.IsExpense,
            EventId = s.Id
            }).ToList();
        }
    }
}
