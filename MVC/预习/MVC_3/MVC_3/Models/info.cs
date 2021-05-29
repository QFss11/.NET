using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_3.Models
{
    public class info
    {
        public info() { }
        public info(string email,string nick)
        {
            this.Email = email;
            this.Nick = nick;
        }
        public string Email { get; set; }
        public string Nick { get; set; }
    }
}