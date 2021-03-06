﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MyOffice
{
    public partial class FrmMain : Form
    {
        #region VARIABLES

        public int UserLevel;
        public string ConnectionString;

        private string _mainRegPath = @"SOFTWARE\JRV Soltuions\My Office";
        private SqlConnection _connection;
        private SqlCommand _command;
        private string _connectionString = @"Data Source=LEANNE\SQLSERVER2016; Initial Catalog=MyLaptopShop; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=True; ApplicationIntent=ReadWrite; MultiSubnetFailover=False; User Id = Admin; Password=Admin;";
        //private static string _databaseSQL = File.ReadAllText(Properties.Resources.Database,Encoding.ASCII);

        #endregion

        #region CONSTRUCTORS

        public FrmMain()
        {
            InitializeComponent();


        }

        #endregion

        #region METHODS

        internal void SetupMainMenuStrip(int userLevel)
        {
            ToolStripItem menuItem;

            switch (userLevel)
            {
                case 0:     // Disabled

                    break;
                case 1:     // User

                    break;
                case 2:     // Admin

                    break;
                case 3:     // Manager

                    break;
            }
        }

        private string RegistryGetValue(string keyName)
        {
            string subKey = _mainRegPath;

            RegistryKey regKey;

            if (Environment.Is64BitOperatingSystem)
            {
                regKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(subKey);
            }
            else
            {
                regKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subKey);
            }

            if (regKey == null)
            {
                return "Error...";
            }
            else
            {
                return (string)regKey.GetValue(keyName);
            }
        }

        private bool CheckDatabase()
        {
            bool databaseExists = false;

            _connection = new SqlConnection(_connectionString);

            // Check if database exists.
            try
            {
                _connection.Open();
                databaseExists = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                databaseExists = false;

            }

            _connection.Close();

            return databaseExists;
        }
        #endregion

        #region PROPERTIES

        #endregion

        #region MAIN MENU STRIP
        private void mnuPreferences_Click(object sender, EventArgs e)
        {
            FrmPreferences form = new FrmPreferences();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuNewClient_Click(object sender, EventArgs e)
        {
            FrmNewClients form = new FrmNewClients();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuCalendar_Click(object sender, EventArgs e)
        {
            FrmCalendar form = new FrmCalendar();
            form.MdiParent = this;
            form.Show();
        }

private void mnuScanner_Click(object sender, EventArgs e)
        {
            FrmScanner form = new FrmScanner();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        
    }
}
