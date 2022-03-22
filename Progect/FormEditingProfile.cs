using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progect
{
    public partial class FormEditingProfile : Form
    {
        DataTable dataTableImport;
        private string idCountry;
        private string path;
        private string idRacer;
        private string pathPhotoByte;
        private Customer customer = new Customer();
        private SQLManager sqlManager = new SQLManager();
        public DataTable Data_Table { 
            set { 
                dataTableImport = value;
                DataRow dataRow = dataTableImport.Rows[0];
                email.Text = dataRow[1].ToString();
                password.Text = dataRow[2].ToString();
                passwordRepeat.Text = dataRow[2].ToString();
                name.Text = dataRow[3].ToString(); 
                surname.Text = dataRow[4].ToString();

                DataTable dataTableRacer = sqlManager.ReturnTable($@"select * from [dbo].[Raser_Seartch] ('{name.Text} {surname.Text}')");
                gender.SelectedItem = dataTableRacer.Rows[0][3].ToString();
                dateTimePicker1.Value = DateTime.Parse(dataTableRacer.Rows[0][4].ToString());
                country.SelectedItem = dataTableRacer.Rows[0][5].ToString();
                pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(dataTableRacer.Rows[0][6].ToString())));
                pathPhotoByte = dataTableRacer.Rows[0][6].ToString();
                idRacer = dataTableRacer.Rows[0][0].ToString();
            } 
        }
        public FormEditingProfile()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            sqlManager.AddComboBox(gender, "[dbo].[Gender]", 1);
            gender.SelectedIndex = 0;
            sqlManager.AddComboBox(country, "[dbo].[Country]", 1);
            country.SelectedIndex = 0;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-10);
        }

        private void back_Click(object sender, EventArgs e)
        {
            FormRacer formRacer = new FormRacer();
            formRacer.Data_Table = sqlManager.ReturnTable($@"select * from [dbo].[Autarization]('{email.Text}','{password.Text}')"); ;
            formRacer.Show();
            this.Hide();
        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[Country_Seartch]('{country.Text}')");
            if (dataTable.Rows.Count > 0)
                idCountry = dataTable.Rows[0][0].ToString();
        }

        private void viewing_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog.Equals(DialogResult.OK))
            {
                path = openFileDialog1.FileName;
                photoName.Text = Path.GetFileNameWithoutExtension(path);
                pictureBox.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox.Invalidate();

                pathPhotoByte = PutImageBinaryInDb(path);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new FormAutorization().Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string message = "";
            string emailStr = email.Text;
            string passwordStr = password.Text;
            string passwordRepeatStr = passwordRepeat.Text;
            string nameStr = name.Text;
            string surnameStr = surname.Text;

            if (emailStr.Replace(" ", "") == "" || passwordStr.Replace(" ", "") == "" || passwordRepeatStr.Replace(" ", "") == "" || nameStr.Replace(" ", "") == "" || surnameStr.Replace(" ", "") == "" || pictureBox.Image == null)
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            if (!isValidEmail(emailStr))
            {
                message += "E-mail адрес должен быть в правильном формате, например, x@x.x\n";
            }

            if (!isValidPassword(passwordStr))
            {
                message += "Минимум 6 символов \n Минимум 1 прописная буква \n Минимум 1 цифра \n По крайней мере один из следующих символов: ! @ # $ % ^";
            }

            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }

            if (passwordRepeatStr != passwordStr)
            {
                MessageBox.Show("Значение повторите пароль должно соответствовать с значением Пароль.");
                return;
            }

            var date = DateTime.Parse(dateTimePicker1.Value.ToString()).ToString("dd-MM-yyyy");

            sqlManager.performingProcedure(
                  new string[] { idRacer,nameStr, surnameStr, gender.Text.Substring(0, 1), date, idCountry, pathPhotoByte },
                  "[dbo].[Racer_update]",
                  new string[] { "ID_Racer", "First_Name", "Last_Name", "Gender", "DateOfBirth", "ID_Country", "Image" }
            );

            sqlManager.performingProcedure(
                  new string[] { emailStr, passwordStr, nameStr, surnameStr, "R" },
                  "[dbo].[User_update]",
                  new string[] { "Email", "Password", "First_Name", "Last_Name"}
            );

        }

        private static string PutImageBinaryInDb(string iFile)
        {
            return Convert.ToBase64String(File.ReadAllBytes(iFile));
        }

        bool isValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        bool isValidPassword(string passwordStr)
        {
            if (passwordStr.Replace(" ", "").Length < 6)
            {
                return false;
            }

            int result = 0;
            for (int i = 0; i <= passwordStr.Length; i++)
            {
                if (Char.IsUpper(passwordStr[i]))
                {
                    result++;
                    break;
                }
            }

            for (int i = 0; i <= passwordStr.Length; i++)
            {
                if (Char.IsDigit(passwordStr[i]))
                {
                    result++;
                    break;
                }
            }

            if (Regex.Match(passwordStr, "[\\!\\@\\#\\$\\%\\^]").Success)
            {
                result++;
            }

            if (result < 3)
            {
                return false;
            }

            return true;
        }
    }
}
