using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnection
{
    public partial class DBConnection : Form
    {
        OleDbConnection connection = new OleDbConnection();       
        
        //string testConnect = @"Provider=SQLOLEDB.1;Password=111;Persist Security Info=True;User ID=Luda;Initial Catalog=Northwind;Data Source=192.168.0.100";
        
        public DBConnection()
        {
            InitializeComponent();
        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        //--Соединение по-умолчанию закрыто, кнопка закрытия соединения должнв быть заблокирована--
        private void DBConnection_Load(object sender, EventArgs e)
        {     
            dBCloseConnectionToolStripMenuItem.Enabled = (connection.State == ConnectionState.Open);
            this.connection.StateChange += new System.Data.StateChangeEventHandler(connection_StateChange);
        }
        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            dBConnectionToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            dBCloseConnectionToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }
        private void dBConnectionToolStripMenuItem_Click(object sender, EventArgs e)
            {
            
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            //--Код из упражнения 1.1.--
            //catch
            //{
            //    MessageBox.Show("Ошибка соединения с базой данных");
            //}

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

        }

        private void dBCloseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            //--нам не нужно это сообщение, т.к. кнопк блокируется, если соединение закрыто
            //else
            //    MessageBox.Show("Соединение с базой данных уже закрыто");
            
        }


        private void списокПодключенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings =
            ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }


        }
    }
}
