using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string conn = "Data Source=(local);Initial Catalog=NORTHWINd;Integrated Security=true;";
                string sql = "SELECT OrderID, OrderDate, ShippedDate, ShipName, ShipAddress, " +
                        "ShipCity, ShipCountry " +
                        "FROM Orders WHERE CustomerID = ";
                Console.WriteLine("Please enter a customer ID (5 characters):");
                sql += "'" + Console.ReadLine().Trim() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Console.WriteLine("None found");
                }
                else
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                        //Console.WriteLine(row[0] + ", " + row[1] + ", " + row[2]);
                        Console.WriteLine(
                                "Order: {0}\nPlaced: {1}\nShipped: {2}\n" +
                                "To Address: {3}\n{4}\n{5}\n{6}\n\n", row["orderid"], row["orderDate"],
                                row["shippedDate"], row["shipName"], row["shipAddress"], row["shipCity"], row["shipCountry"]);

                }
                Console.ReadLine();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

