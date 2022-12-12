using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReceiptDetails
    {
        public int ReceiptDetailsId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public Receipt Receipt { get; set; }
        public Product Product { get; set; }
    }
}
