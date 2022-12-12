using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; }
        public bool PayOff { get; set; }
        public ReceiptDetails ReceiptDetails { get; set; }
        public Client Client { get; set; }
    }
}
