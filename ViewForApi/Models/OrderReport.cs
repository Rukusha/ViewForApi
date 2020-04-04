using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewForApi.Models
{
    public class OrderReport
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public IList<Order> Orders { get; set; } = new List<Order>();
    }
}
