using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewForApi.Models
{
    public class OrderTotal
    {
        public string CreatedDate { get; set; }
        public IList<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Price { get; set; }
    }
}
