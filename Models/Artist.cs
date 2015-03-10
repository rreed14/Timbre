using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timbre.Models
{
    public class Artist
    {
        public virtual string Name { get; set; }
        public virtual int ArtistID { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}