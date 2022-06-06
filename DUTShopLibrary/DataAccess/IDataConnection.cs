using DUTShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DUTShopLibrary.DataAccess
{
    public interface IDataConnection
    {
        #region Customer CRUD

        
        IEnumerable<CustomerModel> Customers_GetAll();
        CustomerModel Customer_Get(int id);
        void Customer_Create(CustomerModel customer);

        bool Customer_Delete(int id);

        bool Customer_Update(CustomerModel customer);
        #endregion

        IEnumerable<ProductModel> Products_GetAll();

        ProductModel Product_Get(int id);

        void Product_Create(ProductModel product);

        bool Product_Delete(int id);

        bool Product_Update(ProductModel product);
    }
}
