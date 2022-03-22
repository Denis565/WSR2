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
    public partial class FormInformation : Form
    {
        private Customer customer = new Customer();

        public FormInformation()
        {
            InitializeComponent();
            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void back_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }
        private void btnListCharitableOrganizations_Click(object sender, EventArgs e)
        {
            FormRosterСharitableOrganizations formListСharitableOrganizations = new FormRosterСharitableOrganizations();
            formListСharitableOrganizations.Show();
            this.Hide();
        }

        private void btnKartSkills_Click(object sender, EventArgs e)
        {
            new FormInformationKartSkills().Show();
            this.Hide();
        }
    }
}
