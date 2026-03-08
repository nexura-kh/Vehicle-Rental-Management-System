namespace Vehicle_Rental_Management_System.Forms
{
    partial class BookingDialog
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
        public void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel13 = new Panel();
            btnAddBooking = new Button();
            panel11 = new Panel();
            txtPhone = new TextBox();
            txtPhoneNumber = new Label();
            panel10 = new Panel();
            txtPrice = new TextBox();
            label9 = new Label();
            panel9 = new Panel();
            txtDuration = new TextBox();
            label8 = new Label();
            panel8 = new Panel();
            txtNationality = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            dtEndDate = new DateTimePicker();
            label6 = new Label();
            panel6 = new Panel();
            dtStartDate = new DateTimePicker();
            label5 = new Label();
            panel5 = new Panel();
            txtLastName = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            cboVehicleName = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            cboVehicleType = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            txtFirstName = new TextBox();
            label1 = new Label();
            panel12 = new Panel();
            btnCancelBooking = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel13.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 242, 241);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(818, 366);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel13, 2, 3);
            tableLayoutPanel1.Controls.Add(panel11, 0, 3);
            tableLayoutPanel1.Controls.Add(panel10, 2, 2);
            tableLayoutPanel1.Controls.Add(panel9, 1, 2);
            tableLayoutPanel1.Controls.Add(panel8, 0, 2);
            tableLayoutPanel1.Controls.Add(panel7, 2, 1);
            tableLayoutPanel1.Controls.Add(panel6, 1, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel12, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(758, 306);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnAddBooking);
            panel13.Location = new Point(507, 231);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(10, 20, 10, 20);
            panel13.Size = new Size(246, 72);
            panel13.TabIndex = 15;
            // 
            // btnAddBooking
            // 
            btnAddBooking.BackColor = Color.FromArgb(20, 184, 166);
            btnAddBooking.Dock = DockStyle.Fill;
            btnAddBooking.FlatStyle = FlatStyle.Popup;
            btnAddBooking.ForeColor = Color.White;
            btnAddBooking.Location = new Point(10, 20);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(226, 32);
            btnAddBooking.TabIndex = 0;
            btnAddBooking.Text = "Add";
            btnAddBooking.UseVisualStyleBackColor = false;
            btnAddBooking.Click += btnSave_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtPhone);
            panel11.Controls.Add(txtPhoneNumber);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 231);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(0, 0, 10, 0);
            panel11.Size = new Size(246, 72);
            panel11.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(0, 20);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 27);
            txtPhone.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.AutoSize = true;
            txtPhoneNumber.Dock = DockStyle.Top;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(0, 0);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(114, 20);
            txtPhoneNumber.TabIndex = 0;
            txtPhoneNumber.Text = "Phone Number";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtPrice);
            panel10.Controls.Add(label9);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(507, 155);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(10, 0, 0, 0);
            panel10.Size = new Size(248, 70);
            panel10.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(10, 20);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(238, 27);
            txtPrice.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 0);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 0;
            label9.Text = "Price";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtDuration);
            panel9.Controls.Add(label8);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(255, 155);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(10, 0, 10, 0);
            panel9.Size = new Size(246, 70);
            panel9.TabIndex = 11;
            // 
            // txtDuration
            // 
            txtDuration.Dock = DockStyle.Fill;
            txtDuration.Location = new Point(10, 20);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(226, 27);
            txtDuration.TabIndex = 1;
            txtDuration.TextChanged += txtDuration_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 0;
            label8.Text = "Duration";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtNationality);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 155);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 0, 10, 0);
            panel8.Size = new Size(246, 70);
            panel8.TabIndex = 10;
            // 
            // txtNationality
            // 
            txtNationality.Dock = DockStyle.Fill;
            txtNationality.Location = new Point(0, 20);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(236, 27);
            txtNationality.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 0;
            label7.Text = "Nationality";
            // 
            // panel7
            // 
            panel7.Controls.Add(dtEndDate);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(507, 79);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10, 0, 0, 0);
            panel7.Size = new Size(248, 70);
            panel7.TabIndex = 5;
            // 
            // dtEndDate
            // 
            dtEndDate.Dock = DockStyle.Fill;
            dtEndDate.Location = new Point(10, 20);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(238, 27);
            dtEndDate.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 0;
            label6.Text = "End Date";
            // 
            // panel6
            // 
            panel6.Controls.Add(dtStartDate);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(255, 79);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(10, 0, 10, 0);
            panel6.Size = new Size(246, 70);
            panel6.TabIndex = 4;
            // 
            // dtStartDate
            // 
            dtStartDate.Dock = DockStyle.Fill;
            dtStartDate.Location = new Point(10, 20);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(226, 27);
            dtStartDate.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Start Date";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtLastName);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 79);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 10, 0);
            panel5.Size = new Size(246, 70);
            panel5.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(0, 20);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(236, 27);
            txtLastName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 0;
            label4.Text = "Last Name";
            // 
            // panel4
            // 
            panel4.Controls.Add(cboVehicleName);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(507, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 0, 0, 0);
            panel4.Size = new Size(248, 70);
            panel4.TabIndex = 2;
            // 
            // cboVehicleName
            // 
            cboVehicleName.Dock = DockStyle.Fill;
            cboVehicleName.FormattingEnabled = true;
            cboVehicleName.Location = new Point(10, 20);
            cboVehicleName.Name = "cboVehicleName";
            cboVehicleName.Size = new Size(238, 28);
            cboVehicleName.TabIndex = 2;
            cboVehicleName.SelectedIndexChanged += cboVehicleName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 0;
            label3.Text = "Vehicle Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(cboVehicleType);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(255, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 0, 10, 0);
            panel3.Size = new Size(246, 70);
            panel3.TabIndex = 1;
            // 
            // cboVehicleType
            // 
            cboVehicleType.Dock = DockStyle.Fill;
            cboVehicleType.FormattingEnabled = true;
            cboVehicleType.Location = new Point(10, 20);
            cboVehicleType.Name = "cboVehicleType";
            cboVehicleType.Size = new Size(226, 28);
            cboVehicleType.TabIndex = 1;
            cboVehicleType.SelectedIndexChanged += cboVehicleType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 0;
            label2.Text = "Vehicle Type";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 10, 0);
            panel2.Size = new Size(246, 70);
            panel2.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(0, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(236, 27);
            txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // panel12
            // 
            panel12.Controls.Add(btnCancelBooking);
            panel12.Location = new Point(255, 231);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(10, 20, 10, 20);
            panel12.Size = new Size(246, 72);
            panel12.TabIndex = 14;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Dock = DockStyle.Fill;
            btnCancelBooking.Location = new Point(10, 20);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(226, 32);
            btnCancelBooking.TabIndex = 0;
            btnCancelBooking.Text = "Cancel";
            btnCancelBooking.UseVisualStyleBackColor = true;
            btnCancelBooking.Click += btnCancel_Click;
            // 
            // BookingDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 426);
            Controls.Add(panel1);
            Name = "BookingDialog";
            Padding = new Padding(30);
            Text = "Booking";
            Load += BookingDialog_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TextBox txtFirstName;
        private Label label1;
        private Panel panel11;
        private TextBox txtPhone;
        private Label txtPhoneNumber;
        private Panel panel10;
        private TextBox txtPrice;
        private Label label9;
        private Panel panel9;
        private TextBox txtDuration;
        private Label label8;
        private Panel panel8;
        private TextBox txtNationality;
        private Label label7;
        private Panel panel7;
        private Label label6;
        private Panel panel6;
        private Label label5;
        private Panel panel5;
        private TextBox txtLastName;
        private Label label4;
        private Panel panel4;
        private TextBox textBox3;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private ComboBox cboVehicleType;
        private ComboBox cboVehicleName;
        private DateTimePicker dtEndDate;
        private DateTimePicker dtStartDate;
        private Panel panel12;
        private Button btnCancelBooking;
        private Panel panel13;
        private Button btnAddBooking;
    }
}