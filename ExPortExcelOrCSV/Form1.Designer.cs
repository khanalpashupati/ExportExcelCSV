namespace ExPortExcelOrCSV
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CustomerDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.panelCustomerDetailsTitle = new System.Windows.Forms.Panel();
            this.panelpanelExportAscsv = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblExportAsCSV = new System.Windows.Forms.Label();
            this.panelExportAsExcel = new System.Windows.Forms.Panel();
            this.pictureBoxExcelIcon = new System.Windows.Forms.PictureBox();
            this.lblExportAsExcel = new System.Windows.Forms.Label();
            this.CustomerDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsDataGridView)).BeginInit();
            this.panelCustomerDetailsTitle.SuspendLayout();
            this.panelpanelExportAscsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelExportAsExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcelIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDetailsDataGridView
            // 
            this.CustomerDetailsDataGridView.AllowUserToAddRows = false;
            this.CustomerDetailsDataGridView.AllowUserToResizeRows = false;
            this.CustomerDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(207)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDetailsDataGridView.EnableHeadersVisualStyles = false;
            this.CustomerDetailsDataGridView.Location = new System.Drawing.Point(0, 30);
            this.CustomerDetailsDataGridView.Name = "CustomerDetailsDataGridView";
            this.CustomerDetailsDataGridView.ReadOnly = true;
            this.CustomerDetailsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerDetailsDataGridView.RowHeadersVisible = false;
            this.CustomerDetailsDataGridView.Size = new System.Drawing.Size(800, 420);
            this.CustomerDetailsDataGridView.TabIndex = 24;
            // 
            // panelCustomerDetailsTitle
            // 
            this.panelCustomerDetailsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelCustomerDetailsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomerDetailsTitle.Controls.Add(this.panelpanelExportAscsv);
            this.panelCustomerDetailsTitle.Controls.Add(this.panelExportAsExcel);
            this.panelCustomerDetailsTitle.Controls.Add(this.CustomerDetails);
            this.panelCustomerDetailsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerDetailsTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerDetailsTitle.Name = "panelCustomerDetailsTitle";
            this.panelCustomerDetailsTitle.Size = new System.Drawing.Size(800, 30);
            this.panelCustomerDetailsTitle.TabIndex = 23;
            // 
            // panelpanelExportAscsv
            // 
            this.panelpanelExportAscsv.Controls.Add(this.pictureBox1);
            this.panelpanelExportAscsv.Controls.Add(this.lblExportAsCSV);
            this.panelpanelExportAscsv.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelpanelExportAscsv.Location = new System.Drawing.Point(495, 0);
            this.panelpanelExportAscsv.Name = "panelpanelExportAscsv";
            this.panelpanelExportAscsv.Size = new System.Drawing.Size(145, 28);
            this.panelpanelExportAscsv.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblExportAsCSV
            // 
            this.lblExportAsCSV.AutoSize = true;
            this.lblExportAsCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExportAsCSV.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportAsCSV.ForeColor = System.Drawing.Color.White;
            this.lblExportAsCSV.Location = new System.Drawing.Point(29, 4);
            this.lblExportAsCSV.Name = "lblExportAsCSV";
            this.lblExportAsCSV.Size = new System.Drawing.Size(102, 19);
            this.lblExportAsCSV.TabIndex = 8;
            this.lblExportAsCSV.Text = "Export as CSV";
            this.lblExportAsCSV.Click += new System.EventHandler(this.lblExportAsCSV_Click);
            // 
            // panelExportAsExcel
            // 
            this.panelExportAsExcel.Controls.Add(this.pictureBoxExcelIcon);
            this.panelExportAsExcel.Controls.Add(this.lblExportAsExcel);
            this.panelExportAsExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExportAsExcel.Location = new System.Drawing.Point(640, 0);
            this.panelExportAsExcel.Name = "panelExportAsExcel";
            this.panelExportAsExcel.Size = new System.Drawing.Size(158, 28);
            this.panelExportAsExcel.TabIndex = 9;
            // 
            // pictureBoxExcelIcon
            // 
            this.pictureBoxExcelIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExcelIcon.Image")));
            this.pictureBoxExcelIcon.InitialImage = null;
            this.pictureBoxExcelIcon.Location = new System.Drawing.Point(3, 1);
            this.pictureBoxExcelIcon.Name = "pictureBoxExcelIcon";
            this.pictureBoxExcelIcon.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxExcelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExcelIcon.TabIndex = 9;
            this.pictureBoxExcelIcon.TabStop = false;
            // 
            // lblExportAsExcel
            // 
            this.lblExportAsExcel.AutoSize = true;
            this.lblExportAsExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExportAsExcel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportAsExcel.ForeColor = System.Drawing.Color.White;
            this.lblExportAsExcel.Location = new System.Drawing.Point(29, 4);
            this.lblExportAsExcel.Name = "lblExportAsExcel";
            this.lblExportAsExcel.Size = new System.Drawing.Size(111, 19);
            this.lblExportAsExcel.TabIndex = 8;
            this.lblExportAsExcel.Text = "Export as Excel";
            this.lblExportAsExcel.Click += new System.EventHandler(this.lblExportAsExcel_Click);
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.AutoSize = true;
            this.CustomerDetails.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetails.ForeColor = System.Drawing.Color.White;
            this.CustomerDetails.Location = new System.Drawing.Point(0, 1);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(152, 24);
            this.CustomerDetails.TabIndex = 6;
            this.CustomerDetails.Text = "Customer Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerDetailsDataGridView);
            this.Controls.Add(this.panelCustomerDetailsTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsDataGridView)).EndInit();
            this.panelCustomerDetailsTitle.ResumeLayout(false);
            this.panelCustomerDetailsTitle.PerformLayout();
            this.panelpanelExportAscsv.ResumeLayout(false);
            this.panelpanelExportAscsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelExportAsExcel.ResumeLayout(false);
            this.panelExportAsExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcelIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDetailsDataGridView;
        private System.Windows.Forms.Panel panelCustomerDetailsTitle;
        private System.Windows.Forms.Panel panelpanelExportAscsv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExportAsCSV;
        private System.Windows.Forms.Panel panelExportAsExcel;
        private System.Windows.Forms.PictureBox pictureBoxExcelIcon;
        private System.Windows.Forms.Label lblExportAsExcel;
        private System.Windows.Forms.Label CustomerDetails;
    }
}

