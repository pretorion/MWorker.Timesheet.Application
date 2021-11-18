using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWorker.Timesheet.Application
{
    public class EventListByHourModel
    {
        public int EventId { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string Name { get; set; }
        public bool IsExpense { get; set; }
    }
}
