namespace MyOffice
{
    partial class FrmCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendar));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.calendarYearView1 = new MyOffice.Controls.CalendarYearView();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(148)))), ((int)(((byte)(68)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // calendarYearView1
            // 
            this.calendarYearView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(148)))), ((int)(((byte)(68)))));
            this.calendarYearView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarYearView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.calendarYearView1.ForeColor = System.Drawing.Color.Black;
            this.calendarYearView1.Location = new System.Drawing.Point(0, 60);
            this.calendarYearView1.Margin = new System.Windows.Forms.Padding(0);
            this.calendarYearView1.MinimumSize = new System.Drawing.Size(492, 250);
            this.calendarYearView1.Name = "calendarYearView1";
            this.calendarYearView1.Padding = new System.Windows.Forms.Padding(4);
            this.calendarYearView1.Size = new System.Drawing.Size(984, 501);
            this.calendarYearView1.TabIndex = 2;
            this.calendarYearView1.Year = 0;
            // 
            // FrmCalendar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(183)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.calendarYearView1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private Controls.CalendarYearView calendarYearView1;
    }
}