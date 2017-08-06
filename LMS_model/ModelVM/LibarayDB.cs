
using LMS_model.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_model
{
  public   class LibarayDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public LibarayDB()
            : base("Dev_library")
        {

        }

    }
}
