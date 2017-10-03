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

namespace Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection dataConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BindMyData();
        }

        public void BindMyData()
        {
            try
            {
                dataConnection.Open();
                SqlCommand comm = new SqlCommand("select * from student", dataConnection);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dataGrid.ItemsSource = ds.Tables[0].DefaultView;
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

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                SqlCommand comm = new SqlCommand("insert into student (StudentID, StudentName, StudentResult) values (@id, @name, @result)", dataConnection);

                SqlParameter param1 = new SqlParameter("@id", SqlDbType.Int);
                comm.Parameters.Add(param1);
                param1.Value = int.Parse(studIdText.Text);

                SqlParameter param2 = new SqlParameter("@name", SqlDbType.NChar, 10);
                comm.Parameters.Add(param2);
                param2.Value = studNameText.Text;

                SqlParameter param3 = new SqlParameter("@result", SqlDbType.Int);
                comm.Parameters.Add(param3);
                param3.Value = int.Parse(studResultText.Text);

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

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                SqlCommand comm = new SqlCommand("update student set StudentName = @name, StudentResult = @result where StudentID = @id", dataConnection);

                SqlParameter param1 = new SqlParameter("@id", SqlDbType.Int);
                comm.Parameters.Add(param1);
                param1.Value = int.Parse(studIdText.Text);

                SqlParameter param2 = new SqlParameter("@name", SqlDbType.NChar, 10);
                comm.Parameters.Add(param2);
                param2.Value = studNameText.Text;

                SqlParameter param3 = new SqlParameter("@result", SqlDbType.Int);
                comm.Parameters.Add(param3);
                param3.Value = int.Parse(studResultText.Text);

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

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataConnection.Open();
                SqlCommand comm = new SqlCommand("delete from student where StudentID = @id", dataConnection);

                SqlParameter param1 = new SqlParameter("@id", SqlDbType.Int);
                comm.Parameters.Add(param1);
                param1.Value = int.Parse(studIdText.Text);

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
