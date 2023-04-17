using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        private string productID, productName, productSize, productUnitSize, productBrand, productOrigin;
        private int productQuantity;
        private bool productDeleted;
        private decimal productPrice;

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

        public string GetProjectName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public string GetProductSize
        {
            get
            {
                return productSize;
            }
            set
            {
                productSize = value;
            }
        }

        public string GetProductUnitSize
        {
            get
            {
                return productUnitSize;
            }
            set
            {
                productUnitSize = value;
            }
        }

        public string GetProductBrand
        {
            get
            {
                return productBrand;
            }
            set
            {
                productBrand = value;
            }
        }

        public string GetProductOrigin
        {
            get
            {
                return productOrigin;
            }
            set
            {
                productOrigin = value;
            }
        }

        public int GetProductQuantity
        {
            get
            {
                return productQuantity;
            }
            set
            {
                productQuantity = value;
            }
        }

        public bool CheckProductDeleted
        {
            get
            {
                return productDeleted;
            }
            set
            {
                productDeleted = value;
            }
        }

        public decimal GetProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }

        public ProductDTO(
            string ProductID,
            string ProductName,
            string ProductSize,
            string ProductUnitSize,
            string ProductBrand,
            string ProductOrigin,
            int ProductQuantity,
            bool ProductDeleted,
            decimal ProductPrice)
        {
            this.productID = ProductID;
            this.productName = ProductName;
            this.productSize = ProductSize;
            this.productUnitSize = ProductUnitSize;
            this.productBrand = ProductBrand;
            this.productOrigin = ProductOrigin;
            this.productQuantity = ProductQuantity;
            this.productDeleted = ProductDeleted;
            this.productPrice = ProductPrice;
        }
    }
}
