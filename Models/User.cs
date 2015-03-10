using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timbre.Models
{
    public class User
    {
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual int UserID { get; set; }
    }
}