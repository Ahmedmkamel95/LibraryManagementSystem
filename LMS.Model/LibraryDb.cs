using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Web;

namespace Library_managment_Systems.Models
{
    public class libarayDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public libarayDb()
            : base("Dev_library")
        {

        }
    }
}