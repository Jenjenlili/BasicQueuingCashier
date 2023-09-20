using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        Timer timer = new Timer();
        CashierClass cashier;

        public CustomerView()
        {
            InitializeComponent();
            cashier = new CashierClass();

            timer.Interval = 1000;
            timer.Tick += new EventHandler(CustomerView_Load);
            timer.Start();

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            DisplayCashierQueues(CashierClass.CashierQueue);
         
        }

        public void DisplayCashierQueues(IEnumerable CashierList)
        {
            foreach (object obj in CashierList)
            {
                if (obj != null)
                {
                    lblNowServing.Text = CashierClass.CashierQueue.Peek().ToString();
                }
                
            }
            
        }
    }
}
