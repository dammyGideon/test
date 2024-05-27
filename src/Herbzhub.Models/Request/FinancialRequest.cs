namespace Herbzhub.Models.Request
{
    public record FinancialRequest
    {
        public string TaxId { get; set; }
        public string BankAccount { get; set; }

        public string BankName { get; set; }
    }
}
    