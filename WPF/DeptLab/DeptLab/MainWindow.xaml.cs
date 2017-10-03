using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;

namespace Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        SqlConnection dataConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        //public SqlConnection dataConnection = new SqlConnection();
        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True;User Instance=True");
        //public SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        // builder.DataSource = ".\\SQLExpress";
        //  builder.InitialCatalog = "Northwind";

        public MainWindow()
        {
            //builder.DataSource = "(local)";
            //builder.InitialCatalog = "sqllab";
            //builder.IntegratedSecurity = true;
            //dataConnection.ConnectionString = builder.ConnectionString;
            //dataConnection.Open();
            InitializeComponent();
        }
        public void BindMyData()
        {
            try
            {
                dataConnection.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM dept", dataConnection);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                myDataGrid.ItemsSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dataConnection.Close();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BindMyData();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                string sql = "insert into dept (deptno,deptname,admrdept) values (@DeptNo,@DeptName,@AdmrDept)";

                SqlCommand comm = new SqlCommand(sql, dataConnection);
                SqlParameter param1 = new SqlParameter("@DeptNo", SqlDbType.Char, 3);
                comm.Parameters.Add(param1);
                param1.Value = txtDeptNo.Text;

                SqlParameter param2 = new SqlParameter("@DeptName", SqlDbType.VarChar, 36);
                comm.Parameters.Add(param2);
                param2.Value = txtDeptName.Text;

                SqlParameter param3 = new SqlParameter("@AdmrDept", SqlDbType.Char, 3);
                comm.Parameters.Add(param3);
                param3.Value = txtAdmrDept.Text;

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dataConnection.Close();
                BindMyData();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                string sql = "update dept set deptname = @DeptName,admrdept = @AdmrDept where deptno = @DeptNo";

                SqlCommand comm = new SqlCommand(sql, dataConnection);
                SqlParameter param1 = new SqlParameter("@DeptNo", SqlDbType.Char, 3);
                comm.Parameters.Add(param1);
                param1.Value = txtDeptNo.Text;

                SqlParameter param2 = new SqlParameter("@DeptName", SqlDbType.VarChar, 36);
                comm.Parameters.Add(param2);
                param2.Value = txtDeptName.Text;

                SqlParameter param3 = new SqlParameter("@AdmrDept", SqlDbType.Char, 3);
                comm.Parameters.Add(param3);
                param3.Value = txtAdmrDept.Text;

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dataConnection.Close();
                BindMyData();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                string sql = "delete from dept where deptno = @DeptNo";

                SqlCommand comm = new SqlCommand(sql, dataConnection);
                SqlParameter param1 = new SqlParameter("@DeptNo", SqlDbType.Char, 3);
                comm.Parameters.Add(param1);
                param1.Value = txtDeptNo.Text;
                /*
                SqlParameter param2 = new SqlParameter("@DeptName", SqlDbType.VarChar, 36);
                comm.Parameters.Add(param2);
                param2.Value = txtDeptName.Text;

                SqlParameter param3 = new SqlParameter("@AdmrDept", SqlDbType.Char, 3);
                comm.Parameters.Add(param3);
                param3.Value = txtAdmrDept.Text;
              
                SqlCommand comm = new SqlCommand("DELETE FROM emp WHERE empno = " '" + txtEmpNo.Text + "' ", dataConnection);
             
                 */
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dataConnection.Close();
                BindMyData();
            }
        }
    }
}
