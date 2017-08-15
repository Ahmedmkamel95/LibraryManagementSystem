using LMS_model.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using LMS_model.ModelVM;

namespace LMS_model
{
    public class LibarayDBContext : IdentityDbContext<User>
    {
       
        //public DbSet<Friend> Friends { get; set; }
        public DbSet<Book> Books { get; set; }


        public static void Init()
        {
            Database.SetInitializer<LibarayDBContext>(new MigrateDatabaseToLatestVersion<LibarayDBContext, Configuration>());
        }
        public LibarayDBContext()
            : base("Dev_library")
        {

        }

    }
}
