using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECT1.TableModels
{
    public class FarmJobsTable
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
