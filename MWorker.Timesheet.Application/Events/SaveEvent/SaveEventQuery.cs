using MediatR;
using MWorker.Timesheet.Application.Interfaces;
using MWorker.Timesheet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MWorker.Timesheet.Application
{
    public class SaveEventQuery : IRequest<int>
    {
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public bool IsExpense { get; set; }
    }
    public class CreateEventQueryHandler : IRequestHandler<SaveEventQuery, int>
    {
        private readonly IApplicationDbContext _context;
        public CreateEventQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(SaveEventQuery request, CancellationToken cancellationToken)
        {
            var entity = new Event
            {
                Date= request.Date,
                Name= request.Name,
                Price= request.Price,
                Quantity= request.Quantity,
                IsExpense = request.IsExpense
            };

            _context.Events.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
