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
    public partial class FormRacerResult : Form
    {
        private Customer customer = new Customer();
        DataTable dataTableImport;
        private SQLManager sqlManager = new SQLManager();

        public DataTable Data_Table
        {
            set
            {
                dataTableImport = value;
                DataRow dataRow = dataTableImport.Rows[0];
                DataTable dataTableRacer = sqlManager.ReturnTable($@"select * from [dbo].[Raser_Seartch] ('{dataRow[3]} {dataRow[4]}')");

                gender.Text = dataTableImport.Rows[0][3].ToString();

                DateTime dateOfBirth = DateTime.Parse(dataTableRacer.Rows[0][4].ToString());

                var year = new DateTime((DateTime.Now - dateOfBirth).Ticks).Year - 1;
                ageCategory.Text = yearAnalitic(year);
            }
        }


        string yearAnalitic(int year) {

            if (year <= 18)  
                return "до 18";

            if (year == 18 && year >= 29)
                return "от 18 до 29";

            if (year == 30 && year >= 39)
                return "от 30 до 39";

            if (year == 40 && year >= 55)
                return "от 40 до 55";

            if (year == 56 && year >= 70)
                return "от 56 до 70";

            if (year > 70)
                return "более 70";

            return "";
        }

        public FormRacerResult()
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

        private void back_Click(object sender, EventArgs e)
        {
            FormRacer formRaser = new FormRacer
            {
                Data_Table = dataTableImport
            };
            formRaser.Show();
            this.Hide();
        }

        private void showAllResults_Click(object sender, EventArgs e)
        {
            FormRacerResultsPast formRacerResultsPast = new FormRacerResultsPast
            {
                Data_Table = dataTableImport
            };
            formRacerResultsPast.Show();
            this.Hide();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headDate_Click(object sender, EventArgs e)
        {

        }

        private void headText_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeEndLable_Click(object sender, EventArgs e)
        {

        }
    }
}
