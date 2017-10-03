using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqlConnection dataConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        //public SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public MainWindow()
        {
            //builder.DataSource = "(local)";
            //builder.InitialCatalog = "SQLLAB";
            //builder.IntegratedSecurity = true;
            //dataConnection.ConnectionString = builder.ConnectionString;
            //dataConnection.Open();
            InitializeComponent();
        }
        
        public void getData()
        {
            try
            {
                dataConnection.Open();
                SqlCommand comm = new SqlCommand("SELECT empno,lastname,firstnme,midinit FROM emp", dataConnection);
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
            getData();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                string sql = "insert into emp (empno,firstnme,midinit,lastname) values (@empNoText,@firstNameText,@midInitText,@lastNameText)";

                SqlCommand comm = new SqlCommand(sql, dataConnection);

                SqlParameter param1 = new SqlParameter("@empNoText", SqlDbType.Char, 6);
                comm.Parameters.Add(param1);
                param1.Value = empNoText.Text;

                SqlParameter param2 = new SqlParameter("@firstNameText", SqlDbType.VarChar, 12);
                comm.Parameters.Add(param2);
                param2.Value = firstNameText.Text;

                SqlParameter param3 = new SqlParameter("@midInitText", SqlDbType.Char, 1);
                comm.Parameters.Add(param3);
                param3.Value = midInitText.Text;

                SqlParameter param4 = new SqlParameter("@lastNameText", SqlDbType.VarChar, 15);
                comm.Parameters.Add(param4);
                param4.Value = lastNameText.Text;

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataConnection.Close();
                getData();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                string sql = "update emp set firstnme = @firstNameText, midinit = @midInitText, lastname = @lastNameText where empno = @empNoText";

                SqlCommand comm = new SqlCommand(sql, dataConnection);

                SqlParameter param1 = new SqlParameter("@empNoText", SqlDbType.Char, 6);
                comm.Parameters.Add(param1);
                param1.Value = empNoText.Text;

                SqlParameter param2 = new SqlParameter("@firstNameText", SqlDbType.VarChar, 12);
                comm.Parameters.Add(param2);
                param2.Value = firstNameText.Text;

                SqlParameter param3 = new SqlParameter("@midInitText", SqlDbType.Char, 1);
                comm.Parameters.Add(param3);
                param3.Value = midInitText.Text;

                SqlParameter param4 = new SqlParameter("@lastNameText", SqlDbType.VarChar, 15);
                comm.Parameters.Add(param4);
                param4.Value = lastNameText.Text;

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataConnection.Close();
                getData();
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                string sql = "delete from emp where empno = @empNoText";

                SqlCommand comm = new SqlCommand(sql, dataConnection);

                SqlParameter param1 = new SqlParameter("@empNoText", SqlDbType.Char, 6);
                comm.Parameters.Add(param1);
                param1.Value = empNoText.Text;

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataConnection.Close();
                getData();
            }
        }
    }
}
