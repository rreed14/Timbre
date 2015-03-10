using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Timbre.Models
{
    public class Album
    {
        [Required]
        public virtual string Name{get; set;}
        [Required]
        public virtual Artist Artist { get; set; }
       
        public virtual int AlbumID { get; set; }
        public virtual int ArtistID { get; set; }

    }
}