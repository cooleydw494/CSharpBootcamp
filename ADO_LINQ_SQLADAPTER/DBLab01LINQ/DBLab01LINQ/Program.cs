using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;


namespace DBLab01LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "(local)";
            builder.InitialCatalog = "SQLLAB";
            builder.IntegratedSecurity = true;

            SqlLab sqlLabDB = new SqlLab(builder.ConnectionString);

            try
            {
                Console.WriteLine("Please enter a department number\n");
                string deptNo = Console.ReadLine();

                var empsQuery = from e in sqlLabDB.EMP
                                where String.Equals(e.WORKDEPT, deptNo)
                                select e;

                if (empsQuery.Any())
                {
                    foreach (var e in empsQuery)
                    {
                        Console.WriteLine($"\nEmployee Number {e.EMPNO}: {e.LASTNAME}, {e.FIRSTNME}");
                    }
                }
                else
                {
                    Console.WriteLine("\nThis department does not exist, or has no employees!");
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
