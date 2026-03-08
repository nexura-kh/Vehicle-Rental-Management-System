namespace Vehicle_Rental_Management_System.Forms
{
    partial class VehicleDialog
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
            addpane = new Panel();
            btnAdd = new Button();
            panel5 = new Panel();
            txtStatus = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            txtName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txtPrice = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtType = new ComboBox();
            vLabel = new Label();
            panel6 = new Panel();
            btnCancel = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            addpane.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
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
            panel1.Size = new Size(594, 330);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(addpane, 1, 2);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(534, 270);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // addpane
            // 
            addpane.Controls.Add(btnAdd);
            addpane.Dock = DockStyle.Fill;
            addpane.Location = new Point(270, 183);
            addpane.Name = "addpane";
            addpane.Padding = new Padding(10, 20, 0, 20);
            addpane.Size = new Size(261, 84);
            addpane.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(20, 184, 166);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(251, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtStatus);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(270, 93);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 10, 0);
            panel5.Size = new Size(261, 84);
            panel5.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Dock = DockStyle.Fill;
            txtStatus.FormattingEnabled = true;
            txtStatus.Location = new Point(0, 20);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(251, 28);
            txtStatus.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Status";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtName);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 93);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 10, 0);
            panel4.Size = new Size(261, 84);
            panel4.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(0, 20);
            txtName.Margin = new Padding(3, 20, 3, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 0;
            label2.Text = "Vehicle Model";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(270, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 10, 0);
            panel3.Size = new Size(261, 84);
            panel3.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(0, 20);
            txtPrice.Margin = new Padding(3, 20, 3, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(251, 27);
            txtPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Price / hour ($)";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtType);
            panel2.Controls.Add(vLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 10, 0);
            panel2.Size = new Size(261, 84);
            panel2.TabIndex = 0;
            // 
            // txtType
            // 
            txtType.Dock = DockStyle.Fill;
            txtType.FormattingEnabled = true;
            txtType.Location = new Point(0, 20);
            txtType.Name = "txtType";
            txtType.Size = new Size(251, 28);
            txtType.TabIndex = 2;
            // 
            // vLabel
            // 
            vLabel.AutoSize = true;
            vLabel.Dock = DockStyle.Top;
            vLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            vLabel.Location = new Point(0, 0);
            vLabel.Name = "vLabel";
            vLabel.Size = new Size(96, 20);
            vLabel.TabIndex = 0;
            vLabel.Text = "Vehicle Type";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCancel);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 183);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 20, 10, 20);
            panel6.Size = new Size(261, 84);
            panel6.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(0, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(251, 44);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // VehicleDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(654, 390);
            Controls.Add(panel1);
            Name = "VehicleDialog";
            Padding = new Padding(30);
            Text = "VehicleDialog";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            addpane.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label vLabel;
        private Panel panel4;
        private TextBox txtName;
        private Label label2;
        private Panel panel3;
        private TextBox txtPrice;
        private Label label1;
        private Panel panel5;
        private Label label3;
        private ComboBox txtStatus;
        private ComboBox txtType;
        private Panel panel6;
        private Button btnCancel;
        private Panel addpane;
        private Button btnAdd;
    }
}