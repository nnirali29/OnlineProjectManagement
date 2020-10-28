using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineProjectManagement.Models
{
    public class PMSContext : DbContext
    {
        public PMSContext() : base("Data Source=.;Initial Catalog=OPMS;Integrated Security=true")
        {
            Database.SetInitializer<PMSContext>(new CreateDatabaseIfNotExists<PMSContext>());


        }
        public DbSet<users> users { get; set; }
        public DbSet<Login > logins { get; set; }

        public DbSet<Payment > payments  { get; set; }
        public DbSet<Project > projects  { get; set; }
        public DbSet<ProjectDocs > projectDocs  { get; set; }
     
        public DbSet<TimeLog> timeLogs { get; set; }
    }
}