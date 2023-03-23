using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace InvoiceMSAPI.Model
{
    public class Admin
    {
        [Key]
        public int adminId { get; set; }

        [StringLength(20)]
        public string adminName { get; set; } = string.Empty;

        [DataType(DataType.EmailAddress)]
        public string adminEmail { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [MaxLength(20, ErrorMessage = "Password must be within 20 characters")]
        [MinLength(6, ErrorMessage = "Password must contain minimum 6 characters")]
        public string adminPassword { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        public string adminPhoneNo { get; set; } = string.Empty;
    }
}
