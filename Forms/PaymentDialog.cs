using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rental_Management_System.Models;

namespace Vehicle_Rental_Management_System.Forms
{
    public partial class PaymentDialog : Form
    {
        private readonly Payment _payment;
        public PaymentDialog(Payment payment = null)
        {
            InitializeComponent();
            _payment = payment;
        }
        public PaymentStatus PaymentStatus => (PaymentStatus)cboPaymentStatus.SelectedItem;
        public DateTime PaymentDate => dtPayDate.Value;

        private void PaymentDialog_Load(object sender, EventArgs e)
        {
            if (_payment != null)
            {
                cboPaymentStatus.Items.AddRange(Enum.GetValues(typeof(PaymentStatus)).Cast<object>().ToArray());
                cboPaymentStatus.SelectedItem = _payment.Status;
                dtPayDate.Value = (_payment.PaymentDate == DateTime.MinValue || _payment.PaymentDate == null)
            ? DateTime.Today
            : _payment.PaymentDate;
            }
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
