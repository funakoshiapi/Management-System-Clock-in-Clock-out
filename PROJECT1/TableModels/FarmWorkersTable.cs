using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECT1.TableModels
{
    public class FarmWorkersTable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WorkerAccessCode { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
