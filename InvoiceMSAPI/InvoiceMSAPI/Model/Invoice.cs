using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMSAPI.Model
{
    public class Invoice
    {
        [Key]
        public int invoiceId { get; set; }

        [DataType(DataType.Date)]
        public string invoiceDate { get; set;}

        [ForeignKey(nameof(Client.clientId))]
        public int clientId { get; set; }

        [ForeignKey(nameof(Project.projectId))]
        public int projectId { get; set; }

        [ForeignKey(nameof(Bill.billId))]
        public int billId { get; set;}

        [DataType(DataType.Currency)]
        public double netAmmount { get; set; }

        public int vat { get; set; }

        [DataType(DataType.Currency)]
        public double inTotalAmmount { get; set; }

        public string description { get; set; }

    }
}
