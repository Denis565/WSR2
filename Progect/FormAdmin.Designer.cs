
namespace Progect
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeEndLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headDate = new System.Windows.Forms.Label();
            this.headText = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inventory = new System.Windows.Forms.Button();
            this.volunteers = new System.Windows.Forms.Button();
            this.charitableOrganizations = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout.Location = new System.Drawing.Point(1042, 34);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(139, 42);
            this.logout.TabIndex = 67;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(446, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 80;
            this.label1.Text = "Меню админестратора";
            // 
            // timeEndLable
            // 
            this.timeEndLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeEndLable.AutoSize = true;
            this.timeEndLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.timeEndLable.Location = new System.Drawing.Point(101, 27);
            this.timeEndLable.Name = "timeEndLable";
            this.timeEndLable.Size = new System.Drawing.Size(178, 29);
            this.timeEndLable.TabIndex = 2;
            this.timeEndLable.Text = "Kart Skills 2017";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.timeEndLable);
            this.panel1.Location = new System.Drawing.Point(-2, 626);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 85);
            this.panel1.TabIndex = 83;
            // 
            // headDate
            // 
            this.headDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headDate.AutoSize = true;
            this.headDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headDate.Location = new System.Drawing.Point(423, 71);
            this.headDate.Name = "headDate";
            this.headDate.Size = new System.Drawing.Size(178, 29);
            this.headDate.TabIndex = 1;
            this.headDate.Text = "Kart Skills 2017";
            // 
            // headText
            // 
            this.headText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headText.AutoSize = true;
            this.headText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headText.Location = new System.Drawing.Point(528, 20);
            this.headText.Name = "headText";
            this.headText.Size = new System.Drawing.Size(229, 32);
            this.headText.TabIndex = 0;
            this.headText.Text = "Kart Skills 2017";
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.headDate);
            this.panelTop.Controls.Add(this.logout);
            this.panelTop.Controls.Add(this.headText);
            this.panelTop.Location = new System.Drawing.Point(-2, -11);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1231, 129);
            this.panelTop.TabIndex = 82;
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventory.Location = new System.Drawing.Point(726, 394);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(422, 90);
            this.inventory.TabIndex = 87;
            this.inventory.Text = "Инвентарь";
            this.inventory.UseVisualStyleBackColor = true;
            // 
            // volunteers
            // 
            this.volunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volunteers.Location = new System.Drawing.Point(726, 262);
            this.volunteers.Name = "volunteers";
            this.volunteers.Size = new System.Drawing.Size(422, 90);
            this.volunteers.TabIndex = 86;
            this.volunteers.Text = "Волонтеры";
            this.volunteers.UseVisualStyleBackColor = true;
            // 
            // charitableOrganizations
            // 
            this.charitableOrganizations.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charitableOrganizations.Location = new System.Drawing.Point(72, 394);
            this.charitableOrganizations.Name = "charitableOrganizations";
            this.charitableOrganizations.Size = new System.Drawing.Size(422, 90);
            this.charitableOrganizations.TabIndex = 84;
            this.charitableOrganizations.Text = "Благотворительные организации";
            this.charitableOrganizations.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.Location = new System.Drawing.Point(72, 262);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(422, 90);
            this.user.TabIndex = 81;
            this.user.Text = "Пользователи";
            this.user.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.volunteers);
            this.Controls.Add(this.charitableOrganizations);
            this.Controls.Add(this.user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1244, 748);
            this.MinimumSize = new System.Drawing.Size(1244, 748);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kart Skills 2017";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeEndLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headDate;
        private System.Windows.Forms.Label headText;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button volunteers;
        private System.Windows.Forms.Button charitableOrganizations;
        private System.Windows.Forms.Button user;
    }
}