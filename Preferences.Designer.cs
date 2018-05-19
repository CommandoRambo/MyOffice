namespace MyOffice
{
    partial class FrmPreferences
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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Country\'s");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Countys");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Inventory Item Types");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Towns");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreferences));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstPages = new System.Windows.Forms.ListBox();
            this.pnlPreferences = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDictionary = new System.Windows.Forms.Panel();
            this.lstDictionary = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDictionaries = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPreferences.SuspendLayout();
            this.pnlDictionary.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(183)))), ((int)(((byte)(116)))));
            this.pnlButtons.Controls.Add(this.butCancel);
            this.pnlButtons.Controls.Add(this.butOK);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pnlButtons.ForeColor = System.Drawing.Color.Black;
            this.pnlButtons.Location = new System.Drawing.Point(0, 331);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(584, 40);
            this.pnlButtons.TabIndex = 0;
            this.pnlButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlButtons_Paint);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(384, 8);
            this.butCancel.Margin = new System.Windows.Forms.Padding(0);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(96, 28);
            this.butCancel.TabIndex = 0;
            this.butCancel.TabStop = false;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(484, 8);
            this.butOK.Margin = new System.Windows.Forms.Padding(0);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(96, 28);
            this.butOK.TabIndex = 0;
            this.butOK.TabStop = false;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(183)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lstPages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(160, 331);
            this.panel1.TabIndex = 1;
            // 
            // lstPages
            // 
            this.lstPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstPages.ForeColor = System.Drawing.Color.Black;
            this.lstPages.FormattingEnabled = true;
            this.lstPages.ItemHeight = 15;
            this.lstPages.Items.AddRange(new object[] {
            "General",
            "Dictionary"});
            this.lstPages.Location = new System.Drawing.Point(8, 10);
            this.lstPages.Margin = new System.Windows.Forms.Padding(0);
            this.lstPages.Name = "lstPages";
            this.lstPages.Size = new System.Drawing.Size(152, 321);
            this.lstPages.TabIndex = 0;
            this.lstPages.SelectedIndexChanged += new System.EventHandler(this.lstPages_SelectedIndexChanged);
            // 
            // pnlPreferences
            // 
            this.pnlPreferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(183)))), ((int)(((byte)(116)))));
            this.pnlPreferences.Controls.Add(this.pnlDictionary);
            this.pnlPreferences.Controls.Add(this.pnlGeneral);
            this.pnlPreferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreferences.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pnlPreferences.ForeColor = System.Drawing.Color.Black;
            this.pnlPreferences.Location = new System.Drawing.Point(160, 0);
            this.pnlPreferences.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.pnlPreferences.Name = "pnlPreferences";
            this.pnlPreferences.Size = new System.Drawing.Size(424, 331);
            this.pnlPreferences.TabIndex = 2;
            // 
            // pnlDictionary
            // 
            this.pnlDictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDictionary.Controls.Add(this.lstDictionary);
            this.pnlDictionary.Controls.Add(this.button2);
            this.pnlDictionary.Controls.Add(this.button1);
            this.pnlDictionary.Controls.Add(this.lstDictionaries);
            this.pnlDictionary.Controls.Add(this.label2);
            this.pnlDictionary.Location = new System.Drawing.Point(8, 8);
            this.pnlDictionary.Margin = new System.Windows.Forms.Padding(8);
            this.pnlDictionary.Name = "pnlDictionary";
            this.pnlDictionary.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.pnlDictionary.Size = new System.Drawing.Size(408, 116);
            this.pnlDictionary.TabIndex = 1;
            // 
            // lstDictionary
            // 
            this.lstDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lstDictionary.ForeColor = System.Drawing.Color.Black;
            this.lstDictionary.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lstDictionary.Location = new System.Drawing.Point(4, 28);
            this.lstDictionary.Name = "lstDictionary";
            this.lstDictionary.Size = new System.Drawing.Size(144, 294);
            this.lstDictionary.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstDictionary.TabIndex = 4;
            this.lstDictionary.UseCompatibleStateImageBehavior = false;
            this.lstDictionary.View = System.Windows.Forms.View.List;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 144;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button2.Location = new System.Drawing.Point(152, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 22);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(280, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 22);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstDictionaries
            // 
            this.lstDictionaries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDictionaries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDictionaries.ForeColor = System.Drawing.Color.Black;
            this.lstDictionaries.GridLines = true;
            this.lstDictionaries.Location = new System.Drawing.Point(152, 28);
            this.lstDictionaries.Name = "lstDictionaries";
            this.lstDictionaries.Size = new System.Drawing.Size(252, 58);
            this.lstDictionaries.TabIndex = 2;
            this.lstDictionaries.UseCompatibleStateImageBehavior = false;
            this.lstDictionaries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 120;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(148)))), ((int)(((byte)(68)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dictionary";
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeneral.Controls.Add(this.label1);
            this.pnlGeneral.Location = new System.Drawing.Point(8, 140);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(8);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.pnlGeneral.Size = new System.Drawing.Size(408, 32);
            this.pnlGeneral.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(148)))), ((int)(((byte)(68)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "General";
            // 
            // FrmPreferences
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 371);
            this.Controls.Add(this.pnlPreferences);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 410);
            this.MinimumSize = new System.Drawing.Size(600, 410);
            this.Name = "FrmPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.FrmPreferences_Load);
            this.pnlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlPreferences.ResumeLayout(false);
            this.pnlDictionary.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstPages;
        private System.Windows.Forms.FlowLayoutPanel pnlPreferences;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDictionary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstDictionaries;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstDictionary;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}