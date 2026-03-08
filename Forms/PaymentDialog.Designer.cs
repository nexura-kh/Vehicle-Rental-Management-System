namespace Vehicle_Rental_Management_System.Forms
{
    partial class PaymentDialog
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            dtPayDate = new DateTimePicker();
            label2 = new Label();
            panel2 = new Panel();
            cboPaymentStatus = new ComboBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            paaa = new Panel();
            btnEditPayment = new Button();
            panel4 = new Panel();
            btnCancelPayment = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            paaa.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(437, 275);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(377, 215);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtPayDate);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 74);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(371, 65);
            panel3.TabIndex = 2;
            // 
            // dtPayDate
            // 
            dtPayDate.Dock = DockStyle.Fill;
            dtPayDate.Location = new Point(10, 30);
            dtPayDate.Name = "dtPayDate";
            dtPayDate.Size = new Size(351, 27);
            dtPayDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Pay Date";
            // 
            // panel2
            // 
            panel2.Controls.Add(cboPaymentStatus);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(371, 65);
            panel2.TabIndex = 1;
            // 
            // cboPaymentStatus
            // 
            cboPaymentStatus.Dock = DockStyle.Fill;
            cboPaymentStatus.FormattingEnabled = true;
            cboPaymentStatus.Location = new Point(10, 30);
            cboPaymentStatus.Name = "cboPaymentStatus";
            cboPaymentStatus.Size = new Size(351, 28);
            cboPaymentStatus.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Payment Status";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(paaa, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 145);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(371, 67);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // paaa
            // 
            paaa.Controls.Add(btnEditPayment);
            paaa.Location = new Point(188, 3);
            paaa.Name = "paaa";
            paaa.Padding = new Padding(10);
            paaa.Size = new Size(179, 61);
            paaa.TabIndex = 1;
            // 
            // btnEditPayment
            // 
            btnEditPayment.BackColor = Color.FromArgb(20, 184, 166);
            btnEditPayment.Dock = DockStyle.Fill;
            btnEditPayment.FlatStyle = FlatStyle.Flat;
            btnEditPayment.ForeColor = Color.White;
            btnEditPayment.Location = new Point(10, 10);
            btnEditPayment.Name = "btnEditPayment";
            btnEditPayment.Size = new Size(159, 41);
            btnEditPayment.TabIndex = 0;
            btnEditPayment.Text = "Save";
            btnEditPayment.UseVisualStyleBackColor = false;
            btnEditPayment.Click += btnEditPayment_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCancelPayment);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(179, 61);
            panel4.TabIndex = 0;
            // 
            // btnCancelPayment
            // 
            btnCancelPayment.Dock = DockStyle.Fill;
            btnCancelPayment.Location = new Point(10, 10);
            btnCancelPayment.Name = "btnCancelPayment";
            btnCancelPayment.Size = new Size(159, 41);
            btnCancelPayment.TabIndex = 0;
            btnCancelPayment.Text = "Cancel";
            btnCancelPayment.UseVisualStyleBackColor = true;
            btnCancelPayment.Click += btnCancelPayment_Click;
            // 
            // PaymentDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 335);
            Controls.Add(panel1);
            Name = "PaymentDialog";
            Padding = new Padding(30);
            Text = "PaymentDialog";
            Load += PaymentDialog_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            paaa.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private DateTimePicker dtPayDate;
        private Label label2;
        private Panel panel2;
        private ComboBox cboPaymentStatus;
        private Label label1;
        private Panel paaa;
        private Button btnEditPayment;
        private Panel panel4;
        private Button btnCancelPayment;
    }
}