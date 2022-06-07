using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECT1.TableModels
{
    public class FarmBuildingsTable
    {
        public Guid Id { get; set; }
        public string BuildingTitle { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
