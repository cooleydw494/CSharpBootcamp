using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection dataConnection = new SqlConnection())
            {

                try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "(local)";
                    builder.InitialCatalog = "SQLLAB";
                    builder.IntegratedSecurity = true;
                    dataConnection.ConnectionString = builder.ConnectionString;
                    dataConnection.Open();

                    Console.WriteLine("Please enter a department number\n");
                    string deptNo = Console.ReadLine();

                    SqlCommand dataCommand = new SqlCommand();
                    dataCommand.Connection = dataConnection;
                    dataCommand.CommandType = CommandType.Text;
                    dataCommand.CommandText =
                        "SELECT empno, lastname, firstnme " +
                        "FROM emp WHERE workdept = @workdeptParam";

                    SqlParameter param = new SqlParameter("@workdeptParam", SqlDbType.Char, 3);
                    param.Value = deptNo;
                    dataCommand.Parameters.Add(param);

                    Console.WriteLine($"\nAbout to find all employees who work in department {deptNo}");
                    SqlDataReader dataReader = dataCommand.ExecuteReader();

                    if (!dataReader.HasRows)
                    {
                        Console.WriteLine($"\nDepartment {deptNo} has no Employees or does not exist");
                    }
                    while (dataReader.Read())
                    {
                        string empNo = dataReader.GetString(0);
                        string lastName = dataReader.GetString(1);
                        string firstName = dataReader.GetString(2);
                        Console.WriteLine($"\nEmployee Number {empNo}: {lastName}, {firstName}");
                    }
                    dataReader.Close();
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
}
