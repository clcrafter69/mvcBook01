using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBook01.Models
{
    public class Book: Pub
    {
        public string Author { get; set; }
        public string Genre { get; set; }

    }
}
