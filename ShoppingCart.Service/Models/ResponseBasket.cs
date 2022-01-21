using Newtonsoft.Json;
using System.Linq;

namespace ShoppingCart.Service.Models
{
    public class ResponseBasket : BasketDto
    {
        [JsonIgnore]
        public int VATValue { get; set; } = 10;

        public string VAT
        {
            get
            {
                return $"{VATValue}%";
            }
        }

        public decimal TotalNet
        {
            get
            {
                return Articles.Sum(a => a.Price);
            }
        }

        public decimal TotalGross
        {
            get
            {
                if (PaysVAT)
                {
                    return Articles.Sum(a => a.Price) * (1 + VATValue / 100);
                }
                else
                {
                    return Articles.Sum(a => a.Price);
                }
            }
        }
    }
}
