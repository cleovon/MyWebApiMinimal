namespace MyWebApiMinimal.Models
{
    public class Sale
    {
        public int IdSale { get; set; }
        public int Payment { get; set; }
        public int Delivery { get; set; }
        public Product Product { get; set; }
    }
}
