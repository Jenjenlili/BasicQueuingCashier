using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        private int x;
        public QueuingForm()
        {
            InitializeComponent();
             
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierClass cashier = new CashierClass();
            


        }
    }
}
