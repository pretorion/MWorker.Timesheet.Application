using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWorker.Timesheet.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public bool IsExpense { get; set; }

    }
}
