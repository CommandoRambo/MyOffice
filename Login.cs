using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class FrmLogin : Form
    {
        #region VARIABLES
        private SqlConnection _connection;
        private SqlCommand _command;
        private string _connectionString = @"Data Source=LEANNE\SQLSERVER2016; Initial Catalog=MyLaptopShop; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=True; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; User Id = Admin; Password=Admin;";

        #endregion

        #region CONSTRUCTORS
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region METHODS
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Application.Exit();
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            // SQL to look up Username.
            bool sqlUsername = DoesUsernameExists(txtUsername.Text);
            // SQL to look up Password.
            string sqlPassword = "";


            _connection = new SqlConnection(_connectionString);

            // Check if database exists.
            try
            {
                _connection.Open();
                //databaseExists = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //databaseExists = false;

            }

            _connection.Close();
        }

        private bool DoesUsernameExists(string username)
        {
            bool usernameExists = false;
            string sqlOutput = String.Empty;

            sqlOutput += "SELECT Username FROM Users";
            sqlOutput += "WHERE";


            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand(sqlOutput,_connection);



            return usernameExists;
        }
        #endregion

        #region PROPERTIES

        #endregion

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
