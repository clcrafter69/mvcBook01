using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBook01.Models
{
    public class Pub
    {
        public int Id { get; set; }
        public string Title { get; set; }
       
        public string Publisher { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Publication Date")]
        public DateTime PubDate { get; set; }





    }
}
