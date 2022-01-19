namespace ShoppingCart.Service.Models
{
    public class ResponseBasket : BasketDto
    {
        public string VAT { get; set; }

        public decimal TotalNet { get; set; }

        public decimal TotalGross { get; set; }
    }
}
