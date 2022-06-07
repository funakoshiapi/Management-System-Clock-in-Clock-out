using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECT1
{
    public class ContextForDB : DbContext
    {
        public ContextForDB(DbContextOptions<ContextForDB> options)
        
    : base(options)
        {
        }

        public DbSet<TableModels.FarmWorkersTable> FarmWorkersTable { get; set; }
        public DbSet<TableModels.FarmBuildingsTable> FarmBuildingsTable { get; set; }
        public DbSet<TableModels.FarmJobsTable> FarmJobsTable { get; set; }
        public DbSet<TableModels.AssignmentsTable> AssignmentsTable { get; set; }
        public DbSet<TableModels.WorkLogsTable> WorkLogsTable { get; set; }
    }
}
