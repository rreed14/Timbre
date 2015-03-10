using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Timbre.Models
{
    public class TimbreDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<TimbreDB>
    {
        protected override void Seed(TimbreDB context)
        {
            context.Artists.Add(new Artist { Name = "Cake" });
            context.Albums.Add(new Album
            { Name = "In the Aeroplane Over the Sea", 
              Artist = new Artist { Name = "Neutral Milk Hotel" } 
            });
            context.Albums.Add(new Album
            {
                Name = "Dookie",
                Artist = new Artist { Name = "Green Day" }
            });
            context.Albums.Add(new Album
            {
                Name = "Costello Music",
                Artist = new Artist { Name = "The Frattellis" }
            });
            base.Seed(context);
        }
    }
}