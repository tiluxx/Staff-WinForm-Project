using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        private DTO.ProductDTO productDTO;

        public ProductDAL(
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
            productDTO = new DTO.ProductDTO(
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
            int isDeleted = 0;
            if (productDTO.CheckProductDeleted)
            {
                isDeleted = 1;
            }
            string query = "insert into Product values ('" +
                productDTO.GetProductID +
                "', '" + productDTO.GetProjectName +
                "', '" + productDTO.GetProductSize +
                "', '" + productDTO.GetProductUnitSize +
                "', '" + productDTO.GetProductBrand +
                "', '" + productDTO.GetProductOrigin +
                "', " + productDTO.GetProductQuantity +
                "', " + productDTO.GetProductPrice +
                "', " + isDeleted + ")";
            Connection.ActionQuery(query);
        }

        public void UpdateProductQuery()
        {
            string query = "update Product set" +
                " ProductName = '" + productDTO.GetProjectName +
                "', ProductSize = '" + productDTO.GetProductSize +
                "', ProductUnitSize = '" + productDTO.GetProductUnitSize +
                "', ProductBrand = '" + productDTO.GetProductBrand +
                "', ProductOrigin = '" + productDTO.GetProductOrigin +
                ", ProductQuantity = " + productDTO.GetProductQuantity +
                ", ProductPrice = " + productDTO.GetProductPrice +
                " where ProductID = '" + productDTO.GetProductID + "'";
            Connection.ActionQuery(query);
        }

        public void DeleteProductQuery()
        {
            string query = "delete from Product where ProductID = '" + productDTO.GetProductID + "'";
            Connection.ActionQuery(query);
        }

        public DataTable SelectProductQuery()
        {
            string s = "select * from Product";
            return Connection.SelectQuery(s);
        }

        public string GetNewProductID()
        {
            return "";
        }
    }
}
