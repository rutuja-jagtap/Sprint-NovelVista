using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Mobile_Store.Entity;

namespace Mobile_Store.DAL.Data
{
    public class Mobile_DbContext : DbContext
    {
        public Mobile_DbContext(DbContextOptions<Mobile_DbContext> options) : base(options)
        {

        }
        public DbSet<Mobile_Details>M_details{ get; set; }
    }
}
