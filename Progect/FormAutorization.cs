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
    public partial class FormAutorization : Form
    {
        private Customer customer = new Customer();
        private SQLManager sqlManager = new SQLManager();
        public FormAutorization()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Autarization]('{email.Text}','{password.Text}')");
            if (dataTable.Rows.Count > 0)
            {
                switch (dataTable.Rows[0][0].ToString())
                {
                    case "Racer":
                        FormRacer formRaser = new FormRacer
                        {
                            Data_Table = dataTable
                        };
                        formRaser.Show();
                        this.Hide();
                        break;

                    case "Coordinator":
                        new FormCoordinatorcs().Show();
                        this.Hide();
                        break;

                    case "Administrator":
                        new FormAdmin().Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show("Авторизация не пройдена.");
                        break;
                }
            }
        }
    }
}
