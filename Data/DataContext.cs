using DSTraningWebAPPAzure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSTraningWebAPPAzure.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
