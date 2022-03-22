using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progect
{
    public partial class FormCheckingEnteredData : Form
    {
        private Customer customer = new Customer();
        public FormCheckingEnteredData()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            new FormAutorization().Show();
            this.Hide();
        }

        private void no_Click(object sender, EventArgs e)
        {
            FormDriverRegistrationMenu formDriverRegistrationMenu = new FormDriverRegistrationMenu();
            formDriverRegistrationMenu.Show();
            this.Hide();
        }

    }
}
