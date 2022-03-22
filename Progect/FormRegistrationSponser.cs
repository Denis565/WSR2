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
    public partial class FormRegistrationSponser : Form
    {
        private Customer customer = new Customer();
        private SQLManager sqlManager = new SQLManager();

        public FormRegistrationSponser()
        {
            InitializeComponent();
            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            sqlManager.AddComboBox(racer, "[dbo].[List_Racer]", 0);

            racer.SelectedIndex = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTimeEnd = new DateTime(2027, 06, 20, 00, 00, 00);
            DateTime res = new DateTime((dateTimeEnd - DateTime.Now).Ticks);

            double sec = res.Second - 1;
            double secresult = sec < 0 ? 0 : sec;

            timeEndLable.Text = $"До начала события осталось {res.Year - 1} лет, " +
                $"{res.Month - 1} месяцев, " +
                $"{res.Day - 1} дней, " +
                $"{res.Hour - 1} часов, " +
                $"{res.Minute - 1} минут и " +
                $"{secresult} секунд";

            if (res.Second < 0)
            {
                timer1.Stop();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            string name = nameSponsor.Text;
            string nameUserCard = nameCard.Text;
            string numberUserCard = numberCard.Text;
            string cvcCard = cvc.Text;
            string yearCard = year.Text;
            string monthCard = month.Text;

            string message = "";

            if (name.Replace(" ", "") == "" || nameUserCard.Replace(" ", "") == "" || numberUserCard.Replace(" ", "") == "" 
                || cvcCard.Replace(" ", "") == "" || yearCard.Replace(" ", "") == "" || monthCard.Replace(" ", "") == "") {

                MessageBox.Show("Проверьте, все поля должны быть заполнены.");
                return;
            }

            if (yearCard.Length != 4 || monthCard.Length != 2) {
                MessageBox.Show("Дата действия карты должна состоять из четырех цифр для года и двух для месяца.");
                return;
            }

            DateTime dateNow = (DateTime.Parse(DateTime.Now.ToShortDateString()));
            DateTime dateCard = new DateTime(Convert.ToInt32(yearCard), Convert.ToInt32(monthCard), 1).AddMonths(1).AddDays(-1);


            message += numberUserCard.Length != 16 ? "Номер кредитной карты должен быть 16 цифр. \n" : "";
            message += DateTime.Compare(dateCard, dateNow) < 0 ? "Срок действия должен быть действительный месяц и год, на текущий день. \n" : "";
            message += cvcCard.Length != 3? "CVC является кодом безопасности, который должен содержать 3 цифры. \n" : "";

            if (message != "") {
                MessageBox.Show(message);
                return;
            }

            //Код для добавления в БД

            string nameRaser = racer.SelectedItem.ToString();
            string idRaser = nameRaser.Split(' ')[3];

            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Search_Chartity] ('{nameSponsor.Text}')");

            sqlManager.performingProcedure_decimal(
                  new string[] {idRaser,dataTable.Rows[0][0].ToString(), Convert.ToDecimal(donationAmount.Text).ToString()},
                  "[dbo].[Registration_insert]",
                  new string[] { "ID_Racer", "ID_Charity", "SponsorshipTarget" }
            );
            ///
            FormConfirmation formConfirmation = new FormConfirmation(nameRaser,donationAmount.Text);
            formConfirmation.Show();
            this.Hide();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (summOperation.Text.Replace(" ", "") != "")
            {
                int donat = Convert.ToInt32(summOperation.Text);
                int donatNow = Convert.ToInt32(donationAmount.Text);

                if (donatNow <= donat)
                {
                    MessageBox.Show("Сумма поддержки не может быть меньше $1 .");
                    return;
                }

                donationAmount.Text = $"{donatNow - 10}";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            donationAmount.Text = $"{Convert.ToInt32(donationAmount.Text) + 10}";
        }
    }
}
