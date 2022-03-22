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
    public partial class FormRacerResultsPast : Form
    {
        private Customer customer = new Customer();
        DataTable dataTableImport;
        private SQLManager sqlManager = new SQLManager();

        public DataTable Data_Table
        {
            set
            {
                dataTableImport = value;
            }
        }
        public FormRacerResultsPast()
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
            FormRacer formRaser = new FormRacer
            {
                Data_Table = dataTableImport
            };
            formRaser.Show();
            this.Hide();
        }
    }
}
