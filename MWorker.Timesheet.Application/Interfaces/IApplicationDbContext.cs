using Microsoft.EntityFrameworkCore;
using MWorker.Timesheet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MWorker.Timesheet.Application.Interfaces
{
    public interface IApplicationDbContext
    {

        DbSet<Event> Events { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
