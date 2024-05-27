namespace Herbzhub.Data.Models
{
    public partial class FinancialInformation : BaseEntity
    {
        public string TaxId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public int DispensaryId { get; set; }
        public Dispensary Dispensary { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
