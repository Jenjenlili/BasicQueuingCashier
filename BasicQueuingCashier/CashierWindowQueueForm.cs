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
    public partial class CashierWindowQueueForm : Form
    {
        
        private Timer timer;
        CashierClass cashier = new CashierClass();
        CustomerView nextqueue = new CustomerView();

        public CashierWindowQueueForm()
        {
            InitializeComponent();
            listCashierQueue.View = View.List;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            
            nextqueue.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           DisplayCashierQueue(CashierClass.CashierQueue);

        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                CashierClass.CashierQueue.Dequeue();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Queue is empty.");
            }
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
