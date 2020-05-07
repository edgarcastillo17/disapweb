using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eventos.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext() : base("MyConnection")
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}