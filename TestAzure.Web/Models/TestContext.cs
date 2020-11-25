using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAzure.Web.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }
        public virtual DbSet<DatabaseModel> DatabaseModels { set; get; }
    }
}
