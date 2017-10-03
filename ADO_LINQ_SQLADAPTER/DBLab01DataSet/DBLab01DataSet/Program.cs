using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBLab01DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a department number...\n");
                string deptNo = Console.ReadLine().Trim();
                string conn = "Data Source=(local); Initial Catalog=SQLLAB; Integrated Security=true;";
                string sql = "SELECT empno, lastname, firstnme FROM emp WHERE workdept ='" + deptNo + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Console.WriteLine($"\nDepartment {deptNo} has no Employees or does not exist");
                }
                else
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Console.WriteLine($"\nEmployee Number {row["empno"]}: {row["lastname"]}, {row["firstnme"]}");
                        //Console.WriteLine($"\nEmployee Number {row[0]}: {row[1]}, {row[2]}");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Exception Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nDONE\n\n");
            }
        }
    }
}