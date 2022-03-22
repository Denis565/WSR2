
namespace Progect
{
    partial class FormRacerResultsPast
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
            this.back = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.headDate = new System.Windows.Forms.Label();
            this.headText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeEndLable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(11, 34);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(139, 42);
            this.back.TabIndex = 68;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.back);
            this.panelTop.Controls.Add(this.headDate);
            this.panelTop.Controls.Add(this.headText);
            this.panelTop.Location = new System.Drawing.Point(-2, -2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1228, 136);
            this.panelTop.TabIndex = 77;
            // 
            // headDate
            // 
            this.headDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headDate.AutoSize = true;
            this.headDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headDate.Location = new System.Drawing.Point(423, 75);
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
            this.headText.Location = new System.Drawing.Point(528, 24);
            this.headText.Name = "headText";
            this.headText.Size = new System.Drawing.Size(229, 32);
            this.headText.TabIndex = 0;
            this.headText.Text = "Kart Skills 2017";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.timeEndLable);
            this.panel1.Location = new System.Drawing.Point(-2, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 85);
            this.panel1.TabIndex = 78;
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
            // FormRacerResultsPast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 701);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Name = "FormRacerResultsPast";
            this.Text = "FormRacerResultsPast";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label headDate;
        private System.Windows.Forms.Label headText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeEndLable;
        private System.Windows.Forms.Timer timer1;
    }
}