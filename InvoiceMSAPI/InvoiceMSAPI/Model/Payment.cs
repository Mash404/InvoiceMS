using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMSAPI.Model
{
    public class Payment
    {
        [Key] 
        public int paymentId { get; set; }

        [ForeignKey(nameof(Bill.billId))]
        public int billId { get; set;}

        [DataType(DataType.Currency)]
        public double inTotalAmmount { get; set; }

        [DataType(DataType.Currency)]
        public double paidAmmount { get; set; }

        [DataType(DataType.Currency)]
        public double dueAmmount { get; set; }

        [DataType(DataType.Date)]
        public string dueDate { get; set;}

    }
}
