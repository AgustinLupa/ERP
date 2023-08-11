using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Data
{
    public class StockData
    {
        public int CreateStock(Stock stock)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"INSERT INTO stock(quantity) 
                                  Values (@Quantity);
                                  SELECT CAST(SCOPE_IDENTITY() as int)";
                    var result = connection.QuerySingle<int>(mysql, stock);
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

        public bool UpdateStock(Stock stock)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE stock SET quantity = @Quantity WHERE id =@Id";
                    var result = connection.Execute(mysql, stock);
                    if (result > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    connection.Close();
                    return false;

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
