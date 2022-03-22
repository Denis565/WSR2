using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progect
{
    public partial class FormRosterСharitableOrganizations : Form
    {
        private Customer customer = new Customer();
        private SQLManager sqlManager = new SQLManager();

        private static List<PictureBox> PictureBoxList = new List<PictureBox>();
        private static List<Label> LableNameOrganizationList = new List<Label>();
        private static List<Label> LableInformationList = new List<Label>();

        private List<string> listNameResurces = new List<string>();

        public FormRosterСharitableOrganizations()
        {
            InitializeComponent();

            customer.timer1 = timer1;
            customer.panelTop = panelTop;
            customer.timeEndLable = timeEndLable;
            customer.timer_tick();
            headDate.Text = $"Москва, Россия {DateTime.Now.ToLongDateString()}";
            panelTop.BackColor = Color.FromArgb(180, 180, 180);

            panelBox.AutoScroll = true;

            DataTable dataTable = sqlManager.ReturnTable($@"select * from [dbo].[List_Charity]");

            foreach (PropertyInfo property in typeof(Properties.Resources).GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                listNameResurces.Add(property.Name);
            }

            init_list_сharity(dataTable);
        }

        private async void init_list_сharity(DataTable dataTable)
        {
            int count = dataTable.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                Label labelNameOrg = new Label();
                Label labelInform = new Label();

                PictureBox lastOldPictureBox = PictureBoxList.LastOrDefault();
                Label lastOldLableNameOrganization = LableNameOrganizationList.LastOrDefault();
                Label lastOldLableInformation = LableInformationList.LastOrDefault();

                string[] imageNameList = dataTable.Rows[i][3].ToString().Split('.');

                string nameImageFile = imageNameList[imageNameList.Count() - 2];
                Bitmap bitmap;

                if (listNameResurces.Contains(nameImageFile))
                {
                    Image im = (Image)Properties.Resources.ResourceManager.GetObject(nameImageFile, System.Globalization.CultureInfo.CurrentCulture);
                    bitmap = (Bitmap)im;
                }
                else {
                    bitmap = Properties.Resources.logotip_charity;
                }

                pictureBox.Image = bitmap;
                pictureBox.Size = new System.Drawing.Size(100, 100);
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox.TabIndex = 18;
                pictureBox.TabStop = false;


                labelNameOrg.AutoSize = true;
                labelNameOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelNameOrg.Size = new System.Drawing.Size(588, 29);
                labelNameOrg.TabIndex = 19;
                labelNameOrg.Text = dataTable.Rows[i][1].ToString();


                labelInform.AutoSize = true;
                labelInform.MaximumSize = new System.Drawing.Size(1250, 75); ;
                labelInform.Size = new System.Drawing.Size(620, 48);
                labelInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelInform.TabIndex = 20;
                labelInform.Text = dataTable.Rows[i][2].ToString();
 
                if (lastOldPictureBox == null)
                {
                    pictureBox.Location = new System.Drawing.Point(55, 0);
                    labelNameOrg.Location = new System.Drawing.Point(211, 10);
                    labelInform.Location = new System.Drawing.Point(211, 40);
                }
                else
                {
                    pictureBox.Location = new System.Drawing.Point(lastOldPictureBox.Location.X, lastOldPictureBox.Location.Y + 140);
                    labelNameOrg.Location = new System.Drawing.Point(lastOldLableNameOrganization.Location.X, lastOldLableNameOrganization.Location.Y + 140);
                    labelInform.Location = new System.Drawing.Point(lastOldLableInformation.Location.X, lastOldLableInformation.Location.Y + 140);
                }

                PictureBoxList.Add(pictureBox);
                LableNameOrganizationList.Add(labelNameOrg);
                LableInformationList.Add(labelInform);

                panelBox.Controls.AddRange(new Control[] {
                    pictureBox,labelNameOrg,labelInform
                });
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            new FormInformation().Show();
            this.Hide();
        }
    }
}
