using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace MyOffice
{
    public partial class FrmScanner : Form
    {
        #region VARIABLES
        private DeviceManager _scanner = new DeviceManager();
        #endregion

        #region CONSTRUCTORS
        public FrmScanner()
        {
            InitializeComponent();
        }
        #endregion

        #region METHODS
        private void FrmScanner_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= _scanner.DeviceInfos.Count; i++)
                {
                    if (_scanner.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        MessageBox.Show("No scanner connected");
                    }
                    else
                    {
                        MessageBox.Show("Scanner connected");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region PROPERTIES

        #endregion


    }
}
