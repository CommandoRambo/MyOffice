using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice.Controls
{
    public partial class CalendarMonth : UserControl
    {
        #region VARIABLES
        private Dictionary<int, string> monthName = new Dictionary<int, string>();
        private Dictionary<int, string> dayName = new Dictionary<int, string>();
        private SortedList<string, string> keyPair = new SortedList<string, string>();
        private EnStartDay _startDay;


        #endregion

        #region CONSTRUCTORS
        public CalendarMonth()
        {
            InitializeComponent();

            base.AutoScaleMode = AutoScaleMode.None;

            monthName.Add(1, "January");
            monthName.Add(2, "Febuary");
            monthName.Add(3, "March");
            monthName.Add(4, "April");
            monthName.Add(5, "May");
            monthName.Add(6, "June");
            monthName.Add(7, "July");
            monthName.Add(8, "August");
            monthName.Add(9, "September");
            monthName.Add(10, "October");
            monthName.Add(11, "November");
            monthName.Add(12, "December");

            dayName.Add(1, "M");
            dayName.Add(2, "Tu");
            dayName.Add(3, "W");
            dayName.Add(4, "Th");
            dayName.Add(5, "F");
            dayName.Add(6, "Sa");
            dayName.Add(7, "Su");
        }
        #endregion

        #region ENUMERATION
        public enum EnStartDay
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        #endregion

        #region METHODS

        private void SetupWeekStartSay()
        {

        }
        #endregion

        #region PROPERTIES
        [Description("Month"), DisplayName("Month"), Category("Calendar"),]
        public string Month
        {
            get
            {
                return lblMonth.Text;
            }
            set
            {

                lblMonth.Text = value;
            }
        }

        [Description("Month"), DisplayName("Month Back Color"), Category("Calendar")]
        public Color MonthBackcolor
        {
            get
            {
                return lblMonth.BackColor;
            }
            set
            {
                lblMonth.BackColor = value;
            }
        }

        [Description("Month"), DisplayName("Month Fore Color"), Category("Calendar")]
        public Color MonthForeColor
        {
            get
            {
                return lblMonth.ForeColor;
            }
            set
            {
                lblMonth.ForeColor = value;
            }
        }
        public int WeekNumber { get; set; }
        public Color WeekNumberBackground { get; set; }
        public Color WeekNumberForeground { get; set; }
        public Color DateBackground { get; set; }
        public Color DateForeground { get; set; }

        [Description("The first day of the your week."), DisplayName("Start Day"), Category("Calendar"),
         Browsable(true)]
        public EnStartDay StartDay
        {
            get
            {
                return _startDay;
            }
            set
            {
                _startDay = value;
            }
        }

        [Description("Font"), DisplayName("Font Month"), Category("Calendar")]
        public Font MonthFont { get { return lblMonth.Font; } set { lblMonth.Font = value; } }

        [Description("Font"), DisplayName("Font Week"), Category("Calendar")]
        public Font WeekFont
        {
            get { return lblMonth.Font; }
            set
            {
                foreach (Label ctrl in tlpCalendar.Controls.OfType<Label>())
                {
                    if (ctrl.Name.StartsWith("lblWeek"))
                    {
                        ctrl.Font = value;
                    }
                }

            }
        }

        [Description("Font"), DisplayName("Font Day"), Category("Calendar")]
        public Font DayFont { get { return lblMonth.Font; } set { lblMonth.Font = value; } }

        [Description("Font"), DisplayName("Font Date"), Category("Calendar")]
        public Font DateFont { get { return lblMonth.Font; } set { lblMonth.Font = value; } }

        #endregion

    }
}
