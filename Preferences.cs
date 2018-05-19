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
    public partial class FrmPreferences : Form
    {
        #region VARIABLES

        #endregion

        #region CONSTRUCTORS
        public FrmPreferences()
        {
            InitializeComponent();

            pnlGeneral.Visible = true;
        }
        #endregion

        #region METHODS
        private void FrmPreferences_Load(object sender, EventArgs e)
        {
            foreach (Panel panel in pnlPreferences.Controls)
            {
                panel.Visible = false;
            }

            pnlGeneral.Visible = true;
            pnlGeneral.Size = new Size(408, 308);
        }

        private void lstPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Panel panel in pnlPreferences.Controls)
            {
                panel.Visible = false;
            }

            switch (lstPages.Text)
            {
                case "General":
                    pnlGeneral.Visible = true;
                    pnlGeneral.Size = new Size(408, 324);
                    break;
                case "Dictionary":
                    pnlDictionary.Visible = true;
                    pnlDictionary.Size = new Size(408, 324);
                    break;
            }
        }

        private void pnlButtons_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Properties.Settings.Default.DarkerGreen);
            graphics.DrawLine(pen, 4,4,580, 4);

        }
        #endregion

        #region PROPERTIES

        #endregion



    }
}
