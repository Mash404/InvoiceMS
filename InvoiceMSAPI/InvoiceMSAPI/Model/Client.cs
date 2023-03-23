using System.ComponentModel.DataAnnotations;

namespace InvoiceMSAPI.Model
{
    public class Client
    {
        [Key] public string clientId { get; set; }
        
        public string clientName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        public string clientEmail { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        public string clientPhoneNo { get; set; } = string.Empty.ToString();
        
        public string clientAddress { get; set; }
    }
}
