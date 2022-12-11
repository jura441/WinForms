namespace DZ_Week_3_bus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.tb_destHours = new System.Windows.Forms.TextBox();
            this.tb_destMinutes = new System.Windows.Forms.TextBox();
            this.tb_destSeconds = new System.Windows.Forms.TextBox();
            this.btn_filterRoute = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_defaultRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(691, 184);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер маршрута";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип автобуса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время отправления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Место назначения";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Укажите место назначения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Часы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Минуты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Секунды";
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(5, 271);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(231, 23);
            this.tb_destination.TabIndex = 9;
            // 
            // tb_destHours
            // 
            this.tb_destHours.Location = new System.Drawing.Point(312, 315);
            this.tb_destHours.Name = "tb_destHours";
            this.tb_destHours.Size = new System.Drawing.Size(100, 23);
            this.tb_destHours.TabIndex = 10;
            // 
            // tb_destMinutes
            // 
            this.tb_destMinutes.Location = new System.Drawing.Point(418, 315);
            this.tb_destMinutes.Name = "tb_destMinutes";
            this.tb_destMinutes.Size = new System.Drawing.Size(100, 23);
            this.tb_destMinutes.TabIndex = 11;
            // 
            // tb_destSeconds
            // 
            this.tb_destSeconds.Location = new System.Drawing.Point(524, 315);
            this.tb_destSeconds.Name = "tb_destSeconds";
            this.tb_destSeconds.Size = new System.Drawing.Size(100, 23);
            this.tb_destSeconds.TabIndex = 12;
            // 
            // btn_filterRoute
            // 
            this.btn_filterRoute.AccessibleName = "btn_filterRoute";
            this.btn_filterRoute.Location = new System.Drawing.Point(12, 384);
            this.btn_filterRoute.Name = "btn_filterRoute";
            this.btn_filterRoute.Size = new System.Drawing.Size(317, 23);
            this.btn_filterRoute.TabIndex = 13;
            this.btn_filterRoute.Text = "Показать доступные маршруты";
            this.btn_filterRoute.UseVisualStyleBackColor = true;
            this.btn_filterRoute.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Время прибытия";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "Укажите желаемое время прибытия\r\n(будут показаны маршруты прибывающее сегодня до " +
    "этого времени)";
            // 
            // btn_defaultRoute
            // 
            this.btn_defaultRoute.AccessibleName = "btn_defaultRoute";
            this.btn_defaultRoute.Location = new System.Drawing.Point(373, 384);
            this.btn_defaultRoute.Name = "btn_defaultRoute";
            this.btn_defaultRoute.Size = new System.Drawing.Size(318, 23);
            this.btn_defaultRoute.TabIndex = 16;
            this.btn_defaultRoute.Text = "Показать все маршруты";
            this.btn_defaultRoute.UseVisualStyleBackColor = true;
            this.btn_defaultRoute.Click += new System.EventHandler(this.btn_defaultRoute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_defaultRoute);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_filterRoute);
            this.Controls.Add(this.tb_destSeconds);
            this.Controls.Add(this.tb_destMinutes);
            this.Controls.Add(this.tb_destHours);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tb_destination;
        private TextBox tb_destHours;
        private TextBox tb_destMinutes;
        private TextBox tb_destSeconds;
        private Button btn_filterRoute;
        private Label label9;
        private Label label10;
        private Button btn_defaultRoute;
    }
}