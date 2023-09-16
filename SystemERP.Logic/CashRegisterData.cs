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
    public class CashRegisterData
    {
        public int CreateRegister(CashRegister cashRegister)
        {
            int id = 0;
            using (var connection = new MySqlConnection(Connection.Connec()))
            {
                try
                {
                    connection.Open();
                    var insertQuery = @"
                        INSERT INTO cashboxes (`ini_amount`, `final_amount`, `opendate`, `closedate`,
                        `transaction_count`, 'id_employee', 'current_balance')
                        VALUES (@Ini_Amount, @Final_Amount, @OpenDate, @CloseDate, @Transaction_Count, @Id_Employee, @Current_Balance);
                        SELECT CAST(SCOPE_IDENTITY() as int)";

                    var result = connection.Execute(insertQuery, new {
                        Ini_Amount = cashRegister.Ini_Amount,
                        Current_Balance = cashRegister.Current_Balance,
                        Final_Amount = cashRegister.Final_Amount,
                        OpenDate = cashRegister.OpenDate,
                        CloseDate = cashRegister.CloseDate,
                        Transaction_Count= cashRegister.Transaction_Count,
                        Id_Employee = cashRegister.Employee.Id});
                    connection.Close();                    
                    return result;
                }
                catch (Exception)
                {
                    connection.Close();
                    return id;
                }
            }            
        }
    }
}
