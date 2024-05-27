namespace Herbzhub.Data.Models
{
    public partial class InventoryManagement : BaseEntity
    {
        public int DispensaryId { get; set; }
        public Dispensary Dispensary { get; set; }
        public string? InventoryTrackingSystem { get; set; }
        public string? ProductCatalog { get; set; }
        public string? SupplierInformation { get; set; }

    }
}
