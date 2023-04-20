using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CartDTO
    {
        private string cartID, customerID;
        private decimal totalBill;
        private bool cartDeleted;


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

        public string GetCustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }
        
        public decimal GetCartTotalBill
        {
            get
            {
                return totalBill;
            }
            set
            {
                totalBill = value;
            }
        }

        public bool CheckCartDeleted
        {
            get
            {
                return cartDeleted;
            }
            set
            {
                cartDeleted = value;
            }
        }


        public CartDTO(
            string CartID,
            string CustomerID,
            decimal TotalBill,
            bool    CartDeleted)
        {
            this.cartID = CartID;
            this.customerID = CustomerID;
            this.totalBill = TotalBill;
            this.cartDeleted = CartDeleted;
        }
    }
}
