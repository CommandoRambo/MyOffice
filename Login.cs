using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        #endregion

        #region CONSTRUCTORS
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region METHODS
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Application.Exit();
            }
        }

        #endregion

        #region PROPERTIES

        #endregion

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
