using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace passbook_core_mvc_crud_app.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public String AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public String BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]

        public String SWIFTCode { get; set; }
        public int Amount { get; set; }
        public DateTime Date {  get; set; }
    }
}
