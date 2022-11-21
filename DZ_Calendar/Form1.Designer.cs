using System.Windows.Forms;

namespace DZ_Calendar
{
    partial class Form1
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
            this.tb_day = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_day
            // 
            this.tb_day.Location = new System.Drawing.Point(40, 41);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(100, 23);
            this.tb_day.TabIndex = 0;
            this.tb_day.TextChanged += new System.EventHandler(this.tb_day_TextChanged);
            // 
            // tb_month
            // 
            this.tb_month.Location = new System.Drawing.Point(159, 41);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(100, 23);
            this.tb_month.TabIndex = 1;
            this.tb_month.TextChanged += new System.EventHandler(this.tb_month_TextChanged);
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(275, 41);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(100, 23);
            this.tb_year.TabIndex = 2;
            this.tb_year.TextChanged += new System.EventHandler(this.tb_year_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(415, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 11, 1, 0, 0, 0, 0), new System.DateTime(2022, 11, 7, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.TodayDate = new System.DateTime(2022, 10, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "День";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.tb_day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TextBox tb_day;
        private TextBox tb_month;
        private TextBox tb_year;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

