namespace Vehicle_Rental_Management_System.Components
{
    partial class GenericManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenericManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            dgvData = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.9961472F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.0038528F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 3, 3, 20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1038, 76);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel3.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel3.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(605, 10);
            tableLayoutPanel3.Margin = new Padding(3, 10, 3, 10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(430, 56);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(254, 226, 226);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(185, 28, 28);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(296, 3);
            btnDelete.Margin = new Padding(10, 3, 10, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(30, 0, 0, 0);
            btnDelete.Size = new Size(124, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "    Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(224, 242, 241);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(15, 118, 110);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(153, 3);
            btnEdit.Margin = new Padding(10, 3, 10, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(30, 0, 0, 0);
            btnEdit.Size = new Size(123, 50);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "    Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(20, 184, 166);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(10, 3);
            btnAdd.Margin = new Padding(10, 3, 10, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(30, 0, 0, 0);
            btnAdd.Size = new Size(123, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "    Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 184, 166);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 12, 0, 0);
            lblTitle.Size = new Size(395, 76);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Customer Management";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 30, 0, 0);
            panel1.Size = new Size(1038, 335);
            panel1.TabIndex = 2;
            // 
            // dgvData
            // 
            // ===== GENERAL =====
            dgvData.Dock = DockStyle.Fill;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.BackgroundColor = Color.FromArgb(249, 250, 251); // softer light gray
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.RowHeadersVisible = false;
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;

            // ===== HEADER STYLE =====
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(20, 184, 166); // Teal
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            headerStyle.SelectionBackColor = Color.FromArgb(20, 184, 166); // prevent blue
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.WrapMode = DataGridViewTriState.True;

            dgvData.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvData.ColumnHeadersHeight = 48;

            // ===== ROW STYLE =====
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.FromArgb(31, 41, 55); // dark text
            rowStyle.Font = new Font("Segoe UI", 10F);
            rowStyle.SelectionBackColor = Color.FromArgb(204, 251, 241); // soft teal
            rowStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
            rowStyle.Padding = new Padding(8, 0, 8, 0);

            dgvData.DefaultCellStyle = rowStyle;

            // ===== ALTERNATING ROWS =====
            dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);

            // ===== GRID STYLE =====
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvData.GridColor = Color.FromArgb(229, 231, 235);

            // ===== ROW HEIGHT =====
            dgvData.RowTemplate.Height = 38;
            // 
            // GenericManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Name = "GenericManagement";
            Size = new Size(1038, 411);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label lblTitle;
        private Panel panel1;
        private DataGridView dgvData;
    }
}
