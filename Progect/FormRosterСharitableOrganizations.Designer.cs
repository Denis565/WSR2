
namespace Progect
{
    partial class FormRosterСharitableOrganizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRosterСharitableOrganizations));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.headDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeEndLable = new System.Windows.Forms.Label();
            this.panelBox = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headText = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.back);
            this.panelTop.Controls.Add(this.headText);
            this.panelTop.Controls.Add(this.headDate);
            this.panelTop.Location = new System.Drawing.Point(1, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1720, 138);
            this.panelTop.TabIndex = 16;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(24, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(139, 42);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // headDate
            // 
            this.headDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headDate.Location = new System.Drawing.Point(0, 59);
            this.headDate.Name = "headDate";
            this.headDate.Size = new System.Drawing.Size(1226, 29);
            this.headDate.TabIndex = 1;
            this.headDate.Text = "Kart Skills 2017";
            this.headDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.timeEndLable);
            this.panel1.Location = new System.Drawing.Point(1, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 84);
            this.panel1.TabIndex = 17;
            // 
            // timeEndLable
            // 
            this.timeEndLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeEndLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeEndLable.Location = new System.Drawing.Point(5, 32);
            this.timeEndLable.Name = "timeEndLable";
            this.timeEndLable.Size = new System.Drawing.Size(1218, 25);
            this.timeEndLable.TabIndex = 2;
            this.timeEndLable.Text = "Kart Skills 2017";
            this.timeEndLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBox
            // 
            this.panelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBox.Location = new System.Drawing.Point(1, 230);
            this.panelBox.Name = "panelBox";
            this.panelBox.Size = new System.Drawing.Size(1226, 384);
            this.panelBox.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 87);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(364, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список благотворительных организаций";
            // 
            // headText
            // 
            this.headText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headText.ForeColor = System.Drawing.Color.Black;
            this.headText.Location = new System.Drawing.Point(0, 9);
            this.headText.MaximumSize = new System.Drawing.Size(2000, 50);
            this.headText.MinimumSize = new System.Drawing.Size(500, 50);
            this.headText.Name = "headText";
            this.headText.Size = new System.Drawing.Size(1226, 50);
            this.headText.TabIndex = 3;
            this.headText.Text = "Kart Skills 2017";
            this.headText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormRosterСharitableOrganizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBox);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRosterСharitableOrganizations";
            this.Text = "FormRosterСharitableOrganizations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label headDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeEndLable;
        private System.Windows.Forms.Panel panelBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headText;
    }
}