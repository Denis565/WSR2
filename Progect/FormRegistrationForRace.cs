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
    public partial class FormRegistrationForRace : Form
    {
        Customer customer = new Customer();
        int idRacer;
        int optionKits;
        double typeRaceAmount;

        private static List<CheckBox> CheckBoxList = new List<CheckBox>();

        public DataTable Data_Table
        {
            set
            {
                dataTableImport = value;

                DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[ReceUser_Seartch] ('{dataTableImport.Rows[0][3].ToString() + dataTableImport.Rows[0][4].ToString()}')");
                idRacer = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            }
        }

        SQLManager sqlManager = new SQLManager();
        private DataTable dataTableImport;

        public FormRegistrationForRace()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            sqlManager.AddComboBox(charatiy, "[dbo].[List_Charity]", 1);
            charatiy.SelectedIndex = 0;

            //optionKits1.Checked = true;
            init();
        }

        int count;

        private void init() 
        {
            DataTable dataTable = sqlManager.ReturnTable("select * from [dbo].[List_Event]");

            count = dataTable.Rows.Count;

            for (int i = 0; i < count; i++) {
                CheckBox chevkBoxInform = new CheckBox();
                CheckBox lastOldCheckBox = CheckBoxList.LastOrDefault();

                chevkBoxInform.AutoSize = true;
                chevkBoxInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                chevkBoxInform.Name = "typeRace3";
                chevkBoxInform.Size = new System.Drawing.Size(181, 24);
                chevkBoxInform.TabIndex = 80;
                chevkBoxInform.Text = $@"{dataTable.Rows[i][1]} ({dataTable.Rows[i][5]}$)";
                chevkBoxInform.UseVisualStyleBackColor = true;
                chevkBoxInform.CheckedChanged += new System.EventHandler(this.typeRace_CheckedChanged);

                if (lastOldCheckBox == null)
                {
                    chevkBoxInform.Location = new System.Drawing.Point(10, 6);
                    chevkBoxInform.Checked = true;
                }
                else
                {
                    chevkBoxInform.Location = new System.Drawing.Point(lastOldCheckBox.Location.X, lastOldCheckBox.Location.Y + 20);
                }

                CheckBoxList.Add(chevkBoxInform);

                panel3.Controls.AddRange(new Control[] {
                    chevkBoxInform
                });

            }

            if (count > 0) {
                registrationFee.Text = dataTable.Rows[0][5].ToString();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FormRacer formRacer = new FormRacer();
            formRacer.Show();
            this.Hide();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(amount.Text.ToString())  <= 0.0) {
                MessageBox.Show("Сумма взноса олжна быть больше 0");
                return;
            }
            sqlManager.performingProcedure_decimal(
                new string[] {idRacer.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), "1",Convert.ToDouble(registrationFee.Text.ToString()).ToString(),idCharty.ToString(),Convert.ToDouble(amount.Text.ToString()).ToString() },
                "[dbo].[Registration2_insert]",
                new string [] { "ID_Racer","Registration_Date","ID_Registration_Status","Cost","ID_Charity","SponsorshipTarget" }
                );

            /*FormRacer formRacer = new FormRacer
            { 
                Data_Table = dataTableImport
            };
            formRacer.Show();
            this.Hide();*/

            new FormConfirmationRegistrationRacer().Show();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            optionKits = 0;
            if (radioButton.Checked)
            {
                if (radioButton.Text == "Вариант А (0$) Номер пилота + браслет")
                    optionKits += 0;

                if (radioButton.Text == "Вариант В (30$) Номер пилота + Шлем + Браслет")
                    optionKits += 30;

                if (radioButton.Text == "Вариант С (50$) Номер пилота + Экипировка + Браслет")
                    optionKits += 50;
            }

            registrationFee.Text = (Convert.ToInt32(typeRaceAmount) + optionKits).ToString();
        }

        private void typeRace_CheckedChanged(object sender, EventArgs e)
        {
            typeRaceAmount = 0.0;
            CheckBox checkBox =  (CheckBox)sender;
            int i = 0;
            foreach (var cb in panel3.Controls.OfType<CheckBox>())
            {
                if (!cb.Checked)
                {
                    i++;
                }
                else
                {
                    string text = cb.Text;

                    typeRaceAmount += Convert.ToDouble
                        (
                            text.Substring(0, text.LastIndexOf('$')).Split('(')[1].ToString()
                        );
                }
            }

            if (i == count)
            {
                checkBox.Checked = true;
            }

            registrationFee.Text = (Convert.ToInt32(typeRaceAmount) + optionKits).ToString();
        }

        int idCharty;

        private void charatiy_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Charity_Seartch] ('{charatiy.Text}')");
            idCharty = Convert.ToInt32(dataTable.Rows[0][0].ToString());
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
    }
}
