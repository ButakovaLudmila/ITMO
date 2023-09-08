using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //--Запрос данных из таблицы Customers--
        private void button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            sqlCommand1.CommandType = CommandType.Text;
            sqlConnection1.Open();
            SqlDataReader reader = sqlCommand1.ExecuteReader();
            bool MoreResults = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                MoreResults = reader.NextResult();
            }
            while (MoreResults);
            MoreResults = reader.NextResult();
            reader.Close();
            sqlCommand1.Connection.Close();
            ResultsTextBox.Text = results.ToString();


        }

        //-- Вызов процедуры Ten Most Expensive Products
        private void button2_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            sqlCommand2.CommandText = "Ten Most Expensive Products";
            sqlCommand2.Connection.Open();
            SqlDataReader reader = sqlCommand2.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    results.Append(reader[i].ToString() + "\t");
                }
                results.Append(Environment.NewLine);
            }
            reader.Close();
            sqlCommand2.Connection.Close();
            ResultsTextBox.Text = results.ToString();

        }

        //--Создание таблицы SalesPersons--
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCommand3.Connection.State != ConnectionState.Open)
                {
                    sqlCommand3.CommandType = CommandType.Text;
                    sqlCommand3.CommandText = "CREATE TABLE SalesPersons (" +
                       "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                       "[FirstName] [nvarchar](50)  NULL, " +
                       "[LastName] [nvarchar](50)  NULL)";
                    sqlCommand3.Connection.Open();
                    sqlCommand3.ExecuteNonQuery();
                    //--sqlCommand3.Connection.Close(); перенесла в finaly
                    MessageBox.Show("Таблица SalesPersons создана");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                    "SQL Error code " + se.NativeError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                sqlCommand3.Connection.Close(); 
            }

        }

        //--Выполнение запроса с параметром. Выборка клиентов из таблицы Customers, где City=London
        private void button4_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            sqlCommand4.CommandType = CommandType.Text;
            sqlCommand4.Parameters["@City"].Value = CityTextBox.Text;
            sqlConnection1.Open();
            SqlDataReader reader = sqlCommand4.ExecuteReader();
            bool MoreResults = false;
            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                MoreResults = reader.NextResult();
            } while (MoreResults);
            reader.Close();
            sqlCommand4.Connection.Close();
            ResultsTextBox.Text = results.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            sqlCommand5.Parameters["@CategoryName"].Value = CategoryNameTextBox.Text;
            sqlCommand5.Parameters["@OrdYear"].Value = OrdYearTextBox.Text;
            sqlCommand5.Connection.Open();
            SqlDataReader reader = sqlCommand5.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    results.Append(reader[i].ToString() + "\t");
                }
                results.Append(Environment.NewLine);
            }
            reader.Close();
            sqlCommand5.Connection.Close();
            ResultsTextBox.Text = results.ToString();
        }
    }
}

