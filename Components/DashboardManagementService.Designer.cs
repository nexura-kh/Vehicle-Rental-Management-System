namespace Vehicle_Rental_Management_System.Components
{
    partial class DashboardManagementService
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
            ss = new Label();
            SuspendLayout();
            // 
            // ss
            // 
            ss.AutoSize = true;
            ss.Dock = DockStyle.Left;
            ss.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ss.ForeColor = Color.FromArgb(20, 184, 166);
            ss.Location = new Point(0, 0);
            ss.Name = "ss";
            ss.Padding = new Padding(0, 12, 0, 0);
            ss.Size = new Size(395, 58);
            ss.TabIndex = 2;
            ss.Text = "Customer Management";
            // 
            // DashboardManagementService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 54, 62);
            Controls.Add(ss);
            Name = "DashboardManagementService";
            Size = new Size(1038, 411);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ss;
    }
}
