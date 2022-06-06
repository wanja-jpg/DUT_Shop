using Dapper;
using DUTShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DUTShopLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string DB_NAME = "DUT_Shop";

        #region Customers CRUD

        
        public IEnumerable<CustomerModel> Customers_GetAll()
        {
            List<CustomerModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                output = connection.Query<CustomerModel>("dbo.spCustomers_GetAll").ToList();
            }

            return output;
        }

        public void Customer_Create(CustomerModel customer)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", customer.FirstName);
                p.Add("@LastName", customer.LastName);
                p.Add("@BirthDate", customer.BirthDate);
                p.Add("@Phone", customer.Phone);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCustomer_Insert", p, commandType: CommandType.StoredProcedure);

                customer.Id = p.Get<int>("@Id");
            }
        }

        public bool Customer_Delete(int id)
        {
            bool result = false;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);

                connection.Execute("dbo.spCustomer_Delete", p, commandType: CommandType.StoredProcedure);
                result = true;
            }
            return result;
        }

        public CustomerModel Customer_Get(int id)
        {
            CustomerModel output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);
                //output = connection.Query<CustomerModel>("dbo.spCustomer_Get", p).First();
                output = connection.QueryFirst<CustomerModel>("SELECT * FROM dbo.Customers WHERE Id=@Id", new { Id = id });
            }

            return output;
        }

        public bool Customer_Update(CustomerModel customer)
        {
            bool result = false;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", customer.Id);
                p.Add("@FirstName", customer.FirstName);
                p.Add("@LastName", customer.LastName);
                p.Add("@BirthDate", customer.BirthDate);
                p.Add("@Phone", customer.Phone);

                connection.Execute("dbo.spCustomer_Update", p, commandType: CommandType.StoredProcedure);
                result = true;
            }
            return result;
        }
        #endregion
        public IEnumerable<ProductModel> Products_GetAll()
        {
            List<ProductModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                output = connection.Query<ProductModel>("dbo.spProducts_GetAll").ToList();
            }

            return output;
        }

        public ProductModel Product_Get(int id)
        {
            ProductModel output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);
                //output = connection.Query<CustomerModel>("dbo.spCustomer_Get", p).First();
                output = connection.QueryFirst<ProductModel>("SELECT * FROM dbo.Products WHERE Id=@Id", new { Id = id });
            }

            return output;
        }

        public void Product_Create(ProductModel product)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", product.Name);
                p.Add("@UnitPrice", product.UnitPrice);
                p.Add("@StockQuantity", product.StockQuantity);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spProduct_Insert", p, commandType: CommandType.StoredProcedure);

                product.Id = p.Get<int>("@Id");
            }
        }

        public bool Product_Delete(int id)
        {
            bool result = false;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", id);

                connection.Execute("dbo.spProduct_Delete", p, commandType: CommandType.StoredProcedure);
                result = true;
            }
            return result;
        }

        public bool Product_Update(ProductModel product)
        {
            bool result = false;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Config.CnnString(DB_NAME)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", product.Id);
                p.Add("@Name", product.Name);
                p.Add("@UnitPrice", product.UnitPrice);
                p.Add("@StockQuantity", product.StockQuantity);

                connection.Execute("dbo.spProduct_Update", p, commandType: CommandType.StoredProcedure);
                result = true;
            }
            return result;
        }
    }
}
