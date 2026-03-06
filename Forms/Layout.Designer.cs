namespace Vehicle_Rental_Management_System.Forms
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            header = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnExit = new Button();
            btnPayment = new Button();
            btnBooking = new Button();
            btnVehicle = new Button();
            btnCustomer = new Button();
            btnLogo = new Button();
            panel1 = new Panel();
            dynamicPanel = new Panel();
            header.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(20, 184, 166);
            header.ColumnCount = 3;
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.8838959F));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.116105F));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 770F));
            header.Controls.Add(tableLayoutPanel1, 2, 0);
            header.Controls.Add(btnLogo, 0, 0);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Padding = new Padding(50, 0, 50, 0);
            header.RowCount = 1;
            header.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            header.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            header.Size = new Size(1138, 92);
            header.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnExit, 4, 0);
            tableLayoutPanel1.Controls.Add(btnPayment, 3, 0);
            tableLayoutPanel1.Controls.Add(btnBooking, 2, 0);
            tableLayoutPanel1.Controls.Add(btnVehicle, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCustomer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(320, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 0, 10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(765, 86);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(254, 226, 226);
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(221, 59, 59);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(622, 13);
            btnExit.Margin = new Padding(10, 3, 10, 3);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(18, 0, 0, 0);
            btnExit.Size = new Size(133, 60);
            btnExit.TabIndex = 4;
            btnExit.Text = " EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPayment
            // 
            btnPayment.Dock = DockStyle.Fill;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Image = (Image)resources.GetObject("btnPayment.Image");
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(469, 13);
            btnPayment.Margin = new Padding(10, 3, 10, 3);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(10, 0, 0, 0);
            btnPayment.Size = new Size(133, 60);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "   PAYMENT";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnBooking
            // 
            btnBooking.Dock = DockStyle.Fill;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(316, 13);
            btnBooking.Margin = new Padding(10, 3, 10, 3);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(10, 0, 0, 0);
            btnBooking.Size = new Size(133, 60);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "    BOOKING";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.Dock = DockStyle.Fill;
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehicle.ForeColor = Color.White;
            btnVehicle.Image = (Image)resources.GetObject("btnVehicle.Image");
            btnVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicle.Location = new Point(163, 13);
            btnVehicle.Margin = new Padding(10, 3, 10, 3);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Padding = new Padding(18, 0, 0, 0);
            btnVehicle.Size = new Size(133, 60);
            btnVehicle.TabIndex = 1;
            btnVehicle.Text = " VEHICLE";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Fill;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(10, 13);
            btnCustomer.Margin = new Padding(10, 3, 10, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(10, 0, 0, 0);
            btnCustomer.Size = new Size(133, 60);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "    CUSTOMER";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Transparent;
            btnLogo.BackgroundImageLayout = ImageLayout.None;
            btnLogo.Dock = DockStyle.Left;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.ForeColor = Color.FromArgb(20, 184, 166);
            btnLogo.Image = (Image)resources.GetObject("btnLogo.Image");
            btnLogo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogo.Location = new Point(53, 3);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(242, 86);
            btnLogo.TabIndex = 1;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 244, 246);
            panel1.Controls.Add(dynamicPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 92);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50);
            panel1.Size = new Size(1138, 511);
            panel1.TabIndex = 1;
            // 
            // dynamicPanel
            // 
            dynamicPanel.BackColor = Color.FromArgb(224, 242, 241);
            dynamicPanel.Dock = DockStyle.Fill;
            dynamicPanel.Location = new Point(50, 50);
            dynamicPanel.Name = "dynamicPanel";
            dynamicPanel.Padding = new Padding(50, 30, 50, 30);
            dynamicPanel.Size = new Size(1038, 411);
            dynamicPanel.TabIndex = 0;
            // 
            // Layout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 99, 235);
            ClientSize = new Size(1138, 603);
            Controls.Add(panel1);
            Controls.Add(header);
            Name = "Layout";
            Text = "Vehicle Rental Management System";
            header.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel header;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCustomer;
        private Button btnVehicle;
        private Button btnPayment;
        private Button btnBooking;
        private Button btnExit;
        private Panel panel1;
        private Panel dynamicPanel;
        private Button btnLogo;
    }
}