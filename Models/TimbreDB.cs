using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Timbre.Models
{
    public class TimbreDB : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<Timbre.Models.Song> Songs { get; set; }

        public System.Data.Entity.DbSet<Timbre.Models.User> Users { get; set; }
    }
    /*public TimbreDB() : base ("name=TimbreDB")
    {

    }**/
}