namespace MyOffice.Controls
{
    partial class CalendarMonth
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonth = new System.Windows.Forms.Label();
            this.tlpCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.lblWeek5 = new System.Windows.Forms.Label();
            this.lblWeek4 = new System.Windows.Forms.Label();
            this.lblWeek3 = new System.Windows.Forms.Label();
            this.lblWeek2 = new System.Windows.Forms.Label();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.lblWeek1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.tlpCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(148)))), ((int)(((byte)(68)))));
            this.tlpCalendar.SetColumnSpan(this.lblMonth, 8);
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(1, 1);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(240, 15);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "January";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tlpCalendar
            // 
            this.tlpCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(37)))));
            this.tlpCalendar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpCalendar.ColumnCount = 8;
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpCalendar.Controls.Add(this.lblWeek5, 0, 6);
            this.tlpCalendar.Controls.Add(this.lblWeek4, 0, 5);
            this.tlpCalendar.Controls.Add(this.lblWeek3, 0, 4);
            this.tlpCalendar.Controls.Add(this.lblWeek2, 0, 3);
            this.tlpCalendar.Controls.Add(this.lblDay7, 6, 1);
            this.tlpCalendar.Controls.Add(this.lblDay6, 5, 1);
            this.tlpCalendar.Controls.Add(this.lblDay5, 4, 1);
            this.tlpCalendar.Controls.Add(this.lblDay4, 3, 1);
            this.tlpCalendar.Controls.Add(this.lblDay2, 2, 1);
            this.tlpCalendar.Controls.Add(this.lblDay3, 3, 1);
            this.tlpCalendar.Controls.Add(this.lblMonth, 0, 0);
            this.tlpCalendar.Controls.Add(this.lblDay1, 1, 1);
            this.tlpCalendar.Controls.Add(this.lblWeek1, 0, 2);
            this.tlpCalendar.Controls.Add(this.lblDate1, 1, 2);
            this.tlpCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCalendar.Location = new System.Drawing.Point(2, 2);
            this.tlpCalendar.Name = "tlpCalendar";
            this.tlpCalendar.RowCount = 7;
            this.tlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCalendar.Size = new System.Drawing.Size(242, 121);
            this.tlpCalendar.TabIndex = 1;
            // 
            // lblWeek5
            // 
            this.lblWeek5.AutoSize = true;
            this.lblWeek5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeek5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeek5.ForeColor = System.Drawing.Color.White;
            this.lblWeek5.Location = new System.Drawing.Point(2, 103);
            this.lblWeek5.Margin = new System.Windows.Forms.Padding(1);
            this.lblWeek5.Name = "lblWeek5";
            this.lblWeek5.Size = new System.Drawing.Size(18, 16);
            this.lblWeek5.TabIndex = 12;
            this.lblWeek5.Text = "00";
            this.lblWeek5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeek4
            // 
            this.lblWeek4.AutoSize = true;
            this.lblWeek4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeek4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeek4.ForeColor = System.Drawing.Color.White;
            this.lblWeek4.Location = new System.Drawing.Point(2, 86);
            this.lblWeek4.Margin = new System.Windows.Forms.Padding(1);
            this.lblWeek4.Name = "lblWeek4";
            this.lblWeek4.Size = new System.Drawing.Size(18, 14);
            this.lblWeek4.TabIndex = 11;
            this.lblWeek4.Text = "00";
            this.lblWeek4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeek3
            // 
            this.lblWeek3.AutoSize = true;
            this.lblWeek3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeek3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeek3.ForeColor = System.Drawing.Color.White;
            this.lblWeek3.Location = new System.Drawing.Point(2, 69);
            this.lblWeek3.Margin = new System.Windows.Forms.Padding(1);
            this.lblWeek3.Name = "lblWeek3";
            this.lblWeek3.Size = new System.Drawing.Size(18, 14);
            this.lblWeek3.TabIndex = 10;
            this.lblWeek3.Text = "00";
            this.lblWeek3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeek2
            // 
            this.lblWeek2.AutoSize = true;
            this.lblWeek2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeek2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeek2.ForeColor = System.Drawing.Color.White;
            this.lblWeek2.Location = new System.Drawing.Point(2, 52);
            this.lblWeek2.Margin = new System.Windows.Forms.Padding(1);
            this.lblWeek2.Name = "lblWeek2";
            this.lblWeek2.Size = new System.Drawing.Size(18, 14);
            this.lblWeek2.TabIndex = 9;
            this.lblWeek2.Text = "00";
            this.lblWeek2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.lblDay7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDay7.ForeColor = System.Drawing.Color.White;
            this.lblDay7.Location = new System.Drawing.Point(209, 18);
            this.lblDay7.Margin = new System.Windows.Forms.Padding(1);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(31, 14);
            this.lblDay7.TabIndex = 7;
            this.lblDay7.Text = "Sa";
            this.lblDay7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.lblDay6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDay6.ForeColor = System.Drawing.Color.White;
            this.lblDay6.Location = new System.Drawing.Point(178, 18);
            this.lblDay6.Margin = new System.Windows.Forms.Padding(1);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(28, 14);
            this.lblDay6.TabIndex = 6;
            this.lblDay6.Text = "F";
            this.lblDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.lblDay5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDay5.ForeColor = System.Drawing.Color.White;
            this.lblDay5.Location = new System.Drawing.Point(147, 18);
            this.lblDay5.Margin = new System.Windows.Forms.Padding(1);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(28, 14);
            this.lblDay5.TabIndex = 5;
            this.lblDay5.Text = "Th";
            this.lblDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.lblDay4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDay4.ForeColor = System.Drawing.Color.White;
            this.lblDay4.Location = new System.Drawing.Point(116, 18);
            this.lblDay4.Margin = new System.Windows.Forms.Padding(1);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(28, 14);
            this.lblDay4.TabIndex = 4;
            this.lblDay4.Text = "W";
            this.lblDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.lblDay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDay2.ForeColor = System.Drawing.Color.White;
            this.lblDay2.Location = new System.Drawing.Point(54, 18);
            this.lblDay2.Margin = new System.Windows.Forms.Padding(1);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(28, 14);
            this.lblDay2.TabIndex = 3;
            this.lblDay2.Text = "M";
            this.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.lblDay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDay3.ForeColor = System.Drawing.Color.White;
            this.lblDay3.Location = new System.Drawing.Point(85, 18);
            this.lblDay3.Margin = new System.Windows.Forms.Padding(1);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(28, 14);
            this.lblDay3.TabIndex = 2;
            this.lblDay3.Text = "Tu";
            this.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.lblDay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDay1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDay1.ForeColor = System.Drawing.Color.White;
            this.lblDay1.Location = new System.Drawing.Point(23, 18);
            this.lblDay1.Margin = new System.Windows.Forms.Padding(1);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(28, 14);
            this.lblDay1.TabIndex = 1;
            this.lblDay1.Text = "Su";
            this.lblDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeek1
            // 
            this.lblWeek1.AutoSize = true;
            this.lblWeek1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeek1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeek1.ForeColor = System.Drawing.Color.White;
            this.lblWeek1.Location = new System.Drawing.Point(2, 35);
            this.lblWeek1.Margin = new System.Windows.Forms.Padding(1);
            this.lblWeek1.Name = "lblWeek1";
            this.lblWeek1.Size = new System.Drawing.Size(18, 14);
            this.lblWeek1.TabIndex = 8;
            this.lblWeek1.Text = "00";
            this.lblWeek1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate1.ForeColor = System.Drawing.Color.White;
            this.lblDate1.Location = new System.Drawing.Point(23, 35);
            this.lblDate1.Margin = new System.Windows.Forms.Padding(1);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(28, 14);
            this.lblDate1.TabIndex = 13;
            this.lblDate1.Text = "00";
            this.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarMonth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(169)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.tlpCalendar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(246, 125);
            this.Name = "CalendarMonth";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(246, 125);
            this.tlpCalendar.ResumeLayout(false);
            this.tlpCalendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TableLayoutPanel tlpCalendar;
        private System.Windows.Forms.Label lblDay7;
        private System.Windows.Forms.Label lblDay6;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.Label lblWeek5;
        private System.Windows.Forms.Label lblWeek4;
        private System.Windows.Forms.Label lblWeek3;
        private System.Windows.Forms.Label lblWeek2;
        private System.Windows.Forms.Label lblWeek1;
        private System.Windows.Forms.Label lblDate1;
    }
}
