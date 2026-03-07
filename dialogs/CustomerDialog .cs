using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Repositories;

namespace Vehicle_Rental_Management_System.dialogs
{
    public partial class CustomerDialog : Form
    {
        public CustomerRepository _customerRepository = new CustomerRepository();

        // Controls
        private Label lblID, lblFirstName, lblSecondName, lblNationality, lblPhoneNumber;
        private TextBox txtID, txtFirstName, txtSecondName, txtNationality, txtPhoneNumber;
        private Button btnOK, btnCancel;

        // Properties to retrieve entered values
        public string CustomerID => txtID.Text.Trim();
        public string FirstName => txtFirstName.Text.Trim();
        public string SecondName => txtSecondName.Text.Trim();
        public string Nationality => txtNationality.Text.Trim();
        public string PhoneNumber => txtPhoneNumber.Text.Trim();

        // ── Add mode ──────────────────────────────────────────────
        public CustomerDialog()
        {
            InitializeComponent();
            InitializeControls();
            this.Text = "Add Customer";
        }

        // ── Edit mode: pre-fills fields from existing customer ID ──
        public CustomerDialog(string customerId)
        {
            InitializeComponent();
            InitializeControls();
            this.Text = "Edit Customer";

            var customer = _customerRepository.GetCustomerById(customerId);
            //MessageBox.Show(customer.ToString());
            if (customer != null)
            {
                txtID.Text = customer.Id.ToString();
                txtID.Enabled = false; // ID should not be editable
                txtFirstName.Text = customer.FirstName;
                txtSecondName.Text = customer.LastName;
                txtNationality.Text = customer.Nationality;
                txtPhoneNumber.Text = customer.PhoneNumber;
            }
        }

        private void InitializeControls()
        {
            this.Size = new Size(380, 320);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            int labelX = 20;
            int textX = 150;
            int startY = 20;
            int spacing = 45;
            int labelWidth = 120;
            int textWidth = 180;

            lblID = new Label() { Text = "ID:", Left = labelX, Top = startY, Width = labelWidth, TextAlign = ContentAlignment.MiddleLeft };
            txtID = new TextBox() { Left = textX, Top = startY, Width = textWidth };

            lblFirstName = new Label() { Text = "First Name:", Left = labelX, Top = startY + spacing, Width = labelWidth, TextAlign = ContentAlignment.MiddleLeft };
            txtFirstName = new TextBox() { Left = textX, Top = startY + spacing, Width = textWidth };

            lblSecondName = new Label() { Text = "Second Name:", Left = labelX, Top = startY + spacing * 2, Width = labelWidth, TextAlign = ContentAlignment.MiddleLeft };
            txtSecondName = new TextBox() { Left = textX, Top = startY + spacing * 2, Width = textWidth };

            lblNationality = new Label() { Text = "Nationality:", Left = labelX, Top = startY + spacing * 3, Width = labelWidth, TextAlign = ContentAlignment.MiddleLeft };
            txtNationality = new TextBox() { Left = textX, Top = startY + spacing * 3, Width = textWidth };

            lblPhoneNumber = new Label() { Text = "Phone Number:", Left = labelX, Top = startY + spacing * 4, Width = labelWidth, TextAlign = ContentAlignment.MiddleLeft };
            txtPhoneNumber = new TextBox() { Left = textX, Top = startY + spacing * 4, Width = textWidth };

            btnOK = new Button()
            {
                Text = "OK",
                Left = 180,
                Top = startY + spacing * 5,
                Width = 80,
                DialogResult = DialogResult.OK
            };
            btnOK.Click += BtnOK_Click;

            btnCancel = new Button()
            {
                Text = "Cancel",
                Left = 270,
                Top = startY + spacing * 5,
                Width = 80,
                DialogResult = DialogResult.Cancel
            };

            this.Controls.AddRange(new Control[]
            {
                lblID, txtID,
                lblFirstName, txtFirstName,
                lblSecondName, txtSecondName,
                lblNationality, txtNationality,
                lblPhoneNumber, txtPhoneNumber,
                btnOK, btnCancel
            });

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtSecondName.Text) ||
                string.IsNullOrWhiteSpace(txtNationality.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}