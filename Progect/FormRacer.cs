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
    public partial class FormRacer : Form
    {
        private SQLManager sqlManager = new SQLManager();
        private Customer customer = new Customer();
        DataTable dataTableImport;

        public DataTable Data_Table { 
            set { 
                dataTableImport = value;
            } 
        }

        public FormRacer()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            string phone = "8-985-987-09-15";
            string email = "test.testDenis@mail.ru";
            new FormContact(phone,email).Show();
        }

        private void editingProfile_Click(object sender, EventArgs e)
        {
            FormEditingProfile formEditingProfile = new FormEditingProfile();
            formEditingProfile.Data_Table = dataTableImport;
            formEditingProfile.Show();
            this.Hide();
        }

        private void registerRace_Click(object sender, EventArgs e)
        {
            FormRegistrationForRace formRegistrationForRace = new FormRegistrationForRace
            {
                Data_Table = dataTableImport
            };
            formRegistrationForRace.Show();
            this.Hide();
        }

        private void myResults_Click(object sender, EventArgs e)
        {
            new FormRacerResult {
                Data_Table = dataTableImport
            }.Show();
            this.Hide();
        }
    }
}
