using System;

namespace PROJECT1.TableModels
{
    public class WorkLogsTable
    {
        public Guid Id { get; set; }
        public string Job { get; set; }
        public string Worker { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateEnded { get; set; } = null;
        public string Building { get; set; } 
    }
}
