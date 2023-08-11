using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Data
{
    public class ProductData
    {
        public int CreateProduct(Product product)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"INSERT INTO products(name, barcode, id_stock, id_supplier, acceptdiscount, price_costmax, price_public, price_costactu) 
                                  Values (@Name, @Barcode, @Id_Stock, @Id_Supplier, @Price_CostMax, @Price_Public, @Price_CostActu, @AcceptDiscount);
                                  SELECT CAST(SCOPE_IDENTITY() as int)";
                    var result = connection.QuerySingle<int>(mysql, product);
                    connection.Close();
                    return result;

                }
                catch (Exception)
                {
                    connection.Close();
                    return 0;
                }
            }
        }

        public bool UpdateProduct(Product product)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE products SET name =@Name, barcode=@Barcode, id_stock=@Id_Stock, id_supplier=@Id_Supplier, acceptdiscount = @AcceptDiscount, price_costmax=@Price_CostMax, price_public=@Price_Public, price_costactu=@Price_CostActu, state=@state) 
                                  WHERE (id = @Id)";
                    var result = connection.Execute(mysql, product);
                    connection.Close();
                    return true;
                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public bool DeleteProduct(Product product)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE products SET state=@State)
                                  WHERE (id = @Id)";
                    var result = connection.Execute(mysql, product);
                    connection.Close();
                    return true;
                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }
            }
        }
    }
}
