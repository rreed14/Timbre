using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timbre.Models
{
    public class Song
    {
        public virtual string Title { get; set; }
        public virtual string Album { get; set; }
        public virtual string Artist { get; set; }
        public virtual int TrackNumber { get; set; }
        public virtual string Genre { get; set; }
        public virtual string SubGenre { get; set; }
        public virtual string Comments { get; set; }
        public virtual Boolean IsInstrumental { get; set; }
        public virtual Boolean IsScore { get; set; }
        public virtual int Length { get; set; }
        public virtual int SongID { get; set; }
    }
}