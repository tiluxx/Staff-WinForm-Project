using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductBUS
    {
        private DAL.ProductDAL productDAL;

        public ProductBUS(
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
            productDAL = new DAL.ProductDAL(
                ProductID,
                ProductName,
                ProductSize,
                ProductUnitSize,
                ProductBrand,
                ProductOrigin,
                ProductQuantity,
                ProductDeleted,
                ProductPrice);
        }

        public void AddProductQuery()
        {
            productDAL.AddProductQuery();
        }

        public void UpdateProductQuery()
        {
            productDAL.UpdateProductQuery();
        }

        public void DeleteProductQuery()
        {
            productDAL.DeleteProductQuery();
        }

        public DataTable SelectProductQuery()
        {
            return productDAL.SelectProductQuery();
        }
    }
}
