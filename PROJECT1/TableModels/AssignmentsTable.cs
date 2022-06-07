using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECT1.TableModels
{
    public class AssignmentsTable
    {
        public Guid Id { get; set; }
        public string WorkerId { get; set; }
        public string BuildingId { get; set; }
        public string JobId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
