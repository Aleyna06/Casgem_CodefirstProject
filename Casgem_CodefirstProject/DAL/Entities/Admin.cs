using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodefirstProject.DAL.Entities
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string  UserName { get; set; }
        public string  Password { get; set; }
    }
}