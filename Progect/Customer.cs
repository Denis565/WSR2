using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progect
{
    class Customer
    {
        public Label timeEndLable;
        public Timer timer1;
        public Panel panelTop;


        public void timer_tick()
        {
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
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
    }
}
