using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CartDetailDTO
    {
        private string cartID, productID;
        private int cartQuantity;

        public string GetCartID
        {
            get
            {
                return cartID;
            }
            set
            {
                cartID = value;
            }
        }

        public string GetProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }


        public int GetCartQuantity
        {
            get
            {
                return cartQuantity;
            }
            set
            {
                cartQuantity = value;
            }
        }


        public CartDetailDTO(
            string CartID,
            string ProductID,
            int CartQuantity)
        {
            this.cartID = CartID;
            this.productID = ProductID;
            this.cartQuantity = CartQuantity;
        }
    }
}
