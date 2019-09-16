using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class Cars
    {
        public virtual int Id { get; set; }
        public virtual String Model { get; set; }
        public virtual String Make { get; set; }
        public virtual Decimal Price { get; set; }


    }
}