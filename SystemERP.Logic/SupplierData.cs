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
    public class SupplierData
    {
        public int CreateSupplier(Supplier supplier)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"INSERT INTO supplier(name, adress, phone) 
                                  Values (@Name, @Adress, @Phone);
                                  SELECT CAST(SCOPE_IDENTITY() as int)";
                    var result = connection.QuerySingle<int>(mysql, supplier);
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

        public bool UpdateSupplier(Supplier supplier)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE supplier SET name = @Name, adress = @Adress, phone = @Phone, state= @state WHERE (id =@Id)";
                    var result = connection.Execute(mysql, supplier);
                    connection.Close();
                    if (result > 0)
                    {                        
                        return true;
                    }                    
                    return false;
                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public bool DeleteSupplier(Supplier supplier)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var mysql = @"UPDATE supplier SET state= 0 WHERE (id =@Id)";
                    var result = connection.Execute(mysql, supplier);
                    connection.Close();
                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    connection.Close();
                    return false;
                }
            }
        }

        public IEnumerable<Supplier> GetAll()
        {

            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var query = @"
                    SELECT s.id, s.name, s.state, s.adress, s.phone,
                    p.id, p.name, p.barcode, p.state, p.id_stock, p.acceptdiscount, p.price_costmax, p.price_public, p.price_costactu
                    FROM supplier s
                    JOIN products p ON s.id = p.id_supplier";
                    var supplierDictionary = new Dictionary<int, Supplier>();
                    connection.Query<Supplier, Product, Supplier>(
                        query,
                        (Supplier, product) =>
                        {
                            if (!supplierDictionary.TryGetValue(Supplier.Id, out var supplierEntry))
                            {
                                supplierEntry = Supplier;
                                supplierEntry.Products = new List<Product>();
                                supplierDictionary.Add(supplierEntry.Id, supplierEntry);
                            }
                            return supplierEntry;
                        },
                        splitOn: "Id, Id"
                    );
                    connection.Close();
                    return supplierDictionary.Values.ToList();
                }
                catch (Exception)
                {
                    connection.Close();
                    List<Supplier> supplier = new List<Supplier>();
                    return supplier;
                }
            }

        }

        public Supplier GetById(int id)
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var query = @"
                    SELECT s.id, s.name, s.state, s.adress, s.phone,
                    p.id, p.name, p.barcode, p.state, p.id_stock, p.acceptdiscount, p.price_costmax, p.price_public, p.price_costactu
                    FROM supplier s
                    JOIN products p ON s.id = p.id_supplier
                    WHERE (s.id = @Id)";
                    var supplierDictionary = new Dictionary<int, Supplier>();
                    connection.Query<Supplier, Product, Supplier>(
                        query,
                        (Supplier, product) =>
                        {
                            if (!supplierDictionary.TryGetValue(Supplier.Id, out var supplierEntry))
                            {
                                supplierEntry = Supplier;
                                supplierEntry.Products = new List<Product>();
                                supplierDictionary.Add(supplierEntry.Id, supplierEntry);
                            }
                            return supplierEntry;
                        },
                        new { Id = id },
                        splitOn: "Id, Id"
                        
                    );
                    connection.Close();
                    return supplierDictionary.Values.FirstOrDefault();
                }
                catch (Exception)
                {
                    connection.Close();
                    Supplier supplier = new Supplier();
                    return supplier;
                }
            }
        }

        public IEnumerable<Supplier> GetActiveSupplier()
        {
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var query = @"
                    SELECT s.id, s.name, s.state, s.adress, s.phone,
                    p.id, p.name, p.barcode, p.state, p.id_stock, p.acceptdiscount, p.price_costmax, p.price_public, p.price_costactu
                    FROM supplier s
                    JOIN products p ON s.id = p.id_supplier
                    WHERE (s.state = 1)";
                    var supplierDictionary = new Dictionary<int, Supplier>();
                    connection.Query<Supplier, Product, Supplier>(
                        query,
                        (Supplier, product) =>
                        {
                            if (!supplierDictionary.TryGetValue(Supplier.Id, out var supplierEntry))
                            {
                                supplierEntry = Supplier;
                                supplierEntry.Products = new List<Product>();
                                supplierDictionary.Add(supplierEntry.Id, supplierEntry);
                            }
                            return supplierEntry;
                        },
                        splitOn: "Id, Id"

                    );
                    connection.Close();
                    return supplierDictionary.Values.ToList();
                }
                catch (Exception)
                {
                    connection.Close();
                    List<Supplier> supplier = new List<Supplier>();
                    return supplier;
                }
            }
        }
    }
}
