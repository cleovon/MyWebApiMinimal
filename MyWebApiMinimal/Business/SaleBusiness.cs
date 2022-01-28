using MyWebApiMinimal.Models;

namespace MyWebApiMinimal.Business
{
    public class SaleBusiness
    {

        public Product Create(Sale sale)
        {
            sale.Product.Enabled = true;
            return sale.Product;
        }
    }
}
