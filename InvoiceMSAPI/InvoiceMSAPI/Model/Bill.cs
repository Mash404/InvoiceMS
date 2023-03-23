using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMSAPI.Model
{
    public class Bill
    {
        [Key]
        public int billId { get; set; }

        [ForeignKey(nameof(Client.clientId))]
        public int clientId { get; set; }

        [ForeignKey(nameof(Project.projectId))]
        public int projectId { get; set; }

        [DataType(DataType.Date)]
        public string billDate { get; set; }

        public int projectQuantity { get; set; }

        public string termsofDelivery { get; set; }

        [DataType(DataType.Date)]
        public string deliveryDate { get; set; }

        public string deliverTo { get; set; }

        public string invoiceTo { get; set; }

        public string termsofPayment { get; set; }

        [DataType(DataType.Currency)]
        public double netAmmount { get; set; }

        public int vat { get; set; }

        [DataType(DataType.Currency)]
        public double inTotalAmmount { get; set;}

        public string status { get; set; }

    }
}
