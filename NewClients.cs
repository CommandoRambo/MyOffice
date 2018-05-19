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
    public partial class FrmNewClients : Form
    {
        #region VARIABLES

        private Dictionary<string, string> CountyDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> AreaDictionary = new Dictionary<string, string>();
        #endregion

        #region CONSTRUCTORS
        public FrmNewClients()
        {
            InitializeComponent();

            cboArea.Items.Clear();
            CreateDictionaries();

            // Populate Area Combobox
            foreach (string area in AreaDictionary.Keys)
            {
                cboArea.Items.Add(area);
            }
        }
        #endregion

        #region METHODS
        private void FrmNewClients_Load(object sender, EventArgs e)
        {
            butSave.Enabled = false;
        }

        private void pnlButtons_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Properties.Settings.Default.DarkerGreen);
            graphics.DrawLine(pen, 4, 4, 580, 4);

        }
        #endregion

        #region PROPERTIES

        #endregion

        #region CREATE DICTIONARIES

        private void CreateDictionaries()
        {
            #region County
            CountyDictionary.Add("Buckinghamshire", "England");
            CountyDictionary.Add("Cambridgeshire", "England");
            CountyDictionary.Add("Cheshire", "England");
            CountyDictionary.Add("Cleveland", "England");
            CountyDictionary.Add("Cornwall", "England");
            CountyDictionary.Add("Cumbria", "England");
            CountyDictionary.Add("Derbyshire", "England");
            CountyDictionary.Add("Devon", "England");
            CountyDictionary.Add("Dorset", "England");
            CountyDictionary.Add("Durham", "England");
            CountyDictionary.Add("East Sussex", "England");
            CountyDictionary.Add("Essex", "England");
            CountyDictionary.Add("Gloucestershire", "England");
            CountyDictionary.Add("Greater London", "England");
            CountyDictionary.Add("Greater Manchester", "England");
            CountyDictionary.Add("Hampshire", "England");
            CountyDictionary.Add("Hertfordshire", "England");
            CountyDictionary.Add("Kent", "England");
            CountyDictionary.Add("Lancashire", "England");
            CountyDictionary.Add("Leicestershire", "England");
            CountyDictionary.Add("Lincolnshire", "England");
            CountyDictionary.Add("Merseyside", "England");
            CountyDictionary.Add("Norfolk", "England");
            CountyDictionary.Add("North Yorkshire", "England");
            CountyDictionary.Add("Northamptonshire", "England");
            CountyDictionary.Add("Northumberland", "England");
            CountyDictionary.Add("Nottinghamshire", "England");
            CountyDictionary.Add("Oxfordshire", "England");
            CountyDictionary.Add("Shropshire", "England");
            CountyDictionary.Add("Somerset", "England");
            CountyDictionary.Add("South Yorkshire", "England");
            CountyDictionary.Add("Staffordshire", "England");
            CountyDictionary.Add("Suffolk", "England");
            CountyDictionary.Add("Surrey", "England");
            CountyDictionary.Add("Tyne and Wear", "England");
            CountyDictionary.Add("Warwickshire", "England");
            CountyDictionary.Add("West Berkshire", "England");
            CountyDictionary.Add("West Midlands", "England");
            CountyDictionary.Add("West Sussex", "England");
            CountyDictionary.Add("West Yorkshire", "England");
            CountyDictionary.Add("Wiltshire", "England");
            CountyDictionary.Add("Worcestershire", "England");
            CountyDictionary.Add("Flintshire", "Wales");
            CountyDictionary.Add("Glamorgan", "Wales");
            CountyDictionary.Add("Merionethshire", "Wales");
            CountyDictionary.Add("Monmouthshire", "Wales");
            CountyDictionary.Add("Montgomeryshire", "Wales");
            CountyDictionary.Add("Pembrokeshire", "Wales");
            CountyDictionary.Add("Radnorshire", "Wales");
            CountyDictionary.Add("Anglesey", "Wales");
            CountyDictionary.Add("Breconshire", "Wales");
            CountyDictionary.Add("Caernarvonshire", "Wales");
            CountyDictionary.Add("Cardiganshire", "Wales");
            CountyDictionary.Add("Carmarthenshire", "Wales");
            CountyDictionary.Add("Denbighshire", "Wales");
            CountyDictionary.Add("Aberdeen City", "Scotland");
            CountyDictionary.Add("Aberdeenshire", "Scotland");
            CountyDictionary.Add("Angus", "Scotland");
            CountyDictionary.Add("Argyll and Bute", "Scotland");
            CountyDictionary.Add("City of Edinburgh", "Scotland");
            CountyDictionary.Add("Clackmannanshire", "Scotland");
            CountyDictionary.Add("Dumfries and Galloway", "Scotland");
            CountyDictionary.Add("Dundee City", "Scotland");
            CountyDictionary.Add("East Ayrshire", "Scotland");
            CountyDictionary.Add("East Dunbartonshire", "Scotland");
            CountyDictionary.Add("East Lothian", "Scotland");
            CountyDictionary.Add("East Renfrewshire", "Scotland");
            CountyDictionary.Add("Eilean Siar", "Scotland");
            CountyDictionary.Add("Falkirk", "Scotland");
            CountyDictionary.Add("Fife", "Scotland");
            CountyDictionary.Add("Glasgow City", "Scotland");
            CountyDictionary.Add("Highland", "Scotland");
            CountyDictionary.Add("Inverclyde", "Scotland");
            CountyDictionary.Add("Midlothian", "Scotland");
            CountyDictionary.Add("Moray", "Scotland");
            CountyDictionary.Add("North Ayrshire", "Scotland");
            CountyDictionary.Add("North Lanarkshire", "Scotland");
            CountyDictionary.Add("Orkney Islands", "Scotland");
            CountyDictionary.Add("Perth and Kinross", "Scotland");
            CountyDictionary.Add("Renfrewshire", "Scotland");
            CountyDictionary.Add("Scottish Borders", "Scotland");
            CountyDictionary.Add("Shetland Islands", "Scotland");
            CountyDictionary.Add("South Ayrshire", "Scotland");
            CountyDictionary.Add("South Lanarkshire", "Scotland");
            CountyDictionary.Add("Stirling", "Scotland");
            CountyDictionary.Add("West Dunbartonshire", "Scotland");
            CountyDictionary.Add("West Lothian", "Scotland");
            CountyDictionary.Add("Antrim", "Northern Ireland");
            CountyDictionary.Add("Armagh", "Northern Ireland");
            CountyDictionary.Add("Down", "Northern Ireland");
            CountyDictionary.Add("Fermanagh", "Northern Ireland");
            CountyDictionary.Add("Derry and Londonderry", "Northern Ireland");
            CountyDictionary.Add("Tyrone", "Northern Ireland");
            #endregion

            #region Area
            AreaDictionary.Add("East Midlands", "England");
            AreaDictionary.Add("East of England", "England");
            AreaDictionary.Add("London", "England");
            AreaDictionary.Add("North East", "England");
            AreaDictionary.Add("Northern Ireland", "England");
            AreaDictionary.Add("Scotland", "England");
            AreaDictionary.Add("South East", "England");
            AreaDictionary.Add("South West", "England");
            AreaDictionary.Add("Wales", "Wales");
            AreaDictionary.Add("West Midlands", "Northern Ireland");
            AreaDictionary.Add("Yorkshire and The Humber", "Scotland");
            #endregion


        }



        #endregion

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Repopulate County Combobox.

        }

        private void cboPostcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Repopulate Town Combobox.

            //TODO Repopulate County Combobox.

            //TODO Repopulate Area Combobox.

        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Repopulate Town Combobox.

        }

        private void cboTowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Repopulate Street Combobox.
        }
    }
}
