namespace AstraWebMvc.Models.ViewModels
{
    using AstraWebMvc.Models.Enums;

    public class SalesRecord
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

     
    }
}
