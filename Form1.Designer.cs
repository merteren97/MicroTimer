namespace MicroTimerStuff
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mhz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PR2 = new System.Windows.Forms.TextBox();
            this.lbl_PR2 = new System.Windows.Forms.Label();
            this.cb_Prescaler3 = new System.Windows.Forms.ComboBox();
            this.cb_Postscaler = new System.Windows.Forms.ComboBox();
            this.lbl_post = new System.Windows.Forms.Label();
            this.cb_Prescaler2 = new System.Windows.Forms.ComboBox();
            this.lbl_Periyot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Prescaler1 = new System.Windows.Forms.ComboBox();
            this.btn_Timer = new System.Windows.Forms.Button();
            this.txt_settimer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Timers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Frekans = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Codes = new System.Windows.Forms.TextBox();
            this.btn_Pic = new System.Windows.Forms.Button();
            this.btn_Byte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mhz);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_PR2);
            this.groupBox1.Controls.Add(this.lbl_PR2);
            this.groupBox1.Controls.Add(this.cb_Prescaler3);
            this.groupBox1.Controls.Add(this.cb_Postscaler);
            this.groupBox1.Controls.Add(this.lbl_post);
            this.groupBox1.Controls.Add(this.cb_Prescaler2);
            this.groupBox1.Controls.Add(this.lbl_Periyot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_Prescaler1);
            this.groupBox1.Controls.Add(this.btn_Timer);
            this.groupBox1.Controls.Add(this.txt_settimer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_Timers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timers";
            // 
            // txt_mhz
            // 
            this.txt_mhz.Location = new System.Drawing.Point(81, 24);
            this.txt_mhz.Name = "txt_mhz";
            this.txt_mhz.Size = new System.Drawing.Size(120, 20);
            this.txt_mhz.TabIndex = 15;
            this.txt_mhz.Text = "8";
            this.txt_mhz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "MHz :";
            // 
            // txt_PR2
            // 
            this.txt_PR2.Location = new System.Drawing.Point(81, 161);
            this.txt_PR2.Name = "txt_PR2";
            this.txt_PR2.Size = new System.Drawing.Size(120, 20);
            this.txt_PR2.TabIndex = 13;
            this.txt_PR2.Text = "249";
            this.txt_PR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PR2.Visible = false;
            // 
            // lbl_PR2
            // 
            this.lbl_PR2.AutoSize = true;
            this.lbl_PR2.Location = new System.Drawing.Point(20, 164);
            this.lbl_PR2.Name = "lbl_PR2";
            this.lbl_PR2.Size = new System.Drawing.Size(34, 13);
            this.lbl_PR2.TabIndex = 12;
            this.lbl_PR2.Text = "PR2 :";
            this.lbl_PR2.Visible = false;
            // 
            // cb_Prescaler3
            // 
            this.cb_Prescaler3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Prescaler3.FormattingEnabled = true;
            this.cb_Prescaler3.Items.AddRange(new object[] {
            "1",
            "4",
            "16"});
            this.cb_Prescaler3.Location = new System.Drawing.Point(65, 103);
            this.cb_Prescaler3.Name = "cb_Prescaler3";
            this.cb_Prescaler3.Size = new System.Drawing.Size(136, 21);
            this.cb_Prescaler3.TabIndex = 10;
            this.cb_Prescaler3.Visible = false;
            // 
            // cb_Postscaler
            // 
            this.cb_Postscaler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Postscaler.FormattingEnabled = true;
            this.cb_Postscaler.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cb_Postscaler.Location = new System.Drawing.Point(65, 132);
            this.cb_Postscaler.Name = "cb_Postscaler";
            this.cb_Postscaler.Size = new System.Drawing.Size(136, 21);
            this.cb_Postscaler.TabIndex = 11;
            this.cb_Postscaler.Visible = false;
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.Location = new System.Drawing.Point(20, 135);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(34, 13);
            this.lbl_post.TabIndex = 10;
            this.lbl_post.Text = "Post :";
            this.lbl_post.Visible = false;
            // 
            // cb_Prescaler2
            // 
            this.cb_Prescaler2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Prescaler2.FormattingEnabled = true;
            this.cb_Prescaler2.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.cb_Prescaler2.Location = new System.Drawing.Point(65, 103);
            this.cb_Prescaler2.Name = "cb_Prescaler2";
            this.cb_Prescaler2.Size = new System.Drawing.Size(136, 21);
            this.cb_Prescaler2.TabIndex = 9;
            this.cb_Prescaler2.Visible = false;
            // 
            // lbl_Periyot
            // 
            this.lbl_Periyot.AutoSize = true;
            this.lbl_Periyot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Periyot.Location = new System.Drawing.Point(66, 224);
            this.lbl_Periyot.Name = "lbl_Periyot";
            this.lbl_Periyot.Size = new System.Drawing.Size(29, 13);
            this.lbl_Periyot.TabIndex = 8;
            this.lbl_Periyot.Text = "0 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Periyot :";
            // 
            // cb_Prescaler1
            // 
            this.cb_Prescaler1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Prescaler1.FormattingEnabled = true;
            this.cb_Prescaler1.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.cb_Prescaler1.Location = new System.Drawing.Point(65, 103);
            this.cb_Prescaler1.Name = "cb_Prescaler1";
            this.cb_Prescaler1.Size = new System.Drawing.Size(136, 21);
            this.cb_Prescaler1.TabIndex = 3;
            // 
            // btn_Timer
            // 
            this.btn_Timer.Location = new System.Drawing.Point(23, 187);
            this.btn_Timer.Name = "btn_Timer";
            this.btn_Timer.Size = new System.Drawing.Size(178, 23);
            this.btn_Timer.TabIndex = 6;
            this.btn_Timer.Text = "Calculate";
            this.btn_Timer.UseVisualStyleBackColor = true;
            this.btn_Timer.Click += new System.EventHandler(this.btn_Timer_Click);
            // 
            // txt_settimer
            // 
            this.txt_settimer.Location = new System.Drawing.Point(81, 77);
            this.txt_settimer.Name = "txt_settimer";
            this.txt_settimer.Size = new System.Drawing.Size(120, 20);
            this.txt_settimer.TabIndex = 5;
            this.txt_settimer.Text = "0";
            this.txt_settimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "set_timer :";
            // 
            // cb_Timers
            // 
            this.cb_Timers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Timers.FormattingEnabled = true;
            this.cb_Timers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Timers.Items.AddRange(new object[] {
            "Timer0",
            "Timer1",
            "Timer2"});
            this.cb_Timers.Location = new System.Drawing.Point(65, 50);
            this.cb_Timers.Name = "cb_Timers";
            this.cb_Timers.Size = new System.Drawing.Size(136, 21);
            this.cb_Timers.TabIndex = 1;
            this.cb_Timers.SelectedIndexChanged += new System.EventHandler(this.cb_Timers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer :";
            // 
            // lbl_Frekans
            // 
            this.lbl_Frekans.AutoSize = true;
            this.lbl_Frekans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Frekans.Location = new System.Drawing.Point(78, 303);
            this.lbl_Frekans.Name = "lbl_Frekans";
            this.lbl_Frekans.Size = new System.Drawing.Size(29, 13);
            this.lbl_Frekans.TabIndex = 10;
            this.lbl_Frekans.Text = "0 Hz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Frekans :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Byte);
            this.groupBox2.Controls.Add(this.btn_Pic);
            this.groupBox2.Controls.Add(this.txt_Codes);
            this.groupBox2.Location = new System.Drawing.Point(237, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 248);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kods";
            // 
            // txt_Codes
            // 
            this.txt_Codes.Location = new System.Drawing.Point(6, 19);
            this.txt_Codes.Multiline = true;
            this.txt_Codes.Name = "txt_Codes";
            this.txt_Codes.Size = new System.Drawing.Size(289, 191);
            this.txt_Codes.TabIndex = 0;
            // 
            // btn_Pic
            // 
            this.btn_Pic.Location = new System.Drawing.Point(6, 216);
            this.btn_Pic.Name = "btn_Pic";
            this.btn_Pic.Size = new System.Drawing.Size(75, 23);
            this.btn_Pic.TabIndex = 1;
            this.btn_Pic.Text = "PIC C Code";
            this.btn_Pic.UseVisualStyleBackColor = true;
            this.btn_Pic.Click += new System.EventHandler(this.btn_Pic_Click);
            // 
            // btn_Byte
            // 
            this.btn_Byte.Location = new System.Drawing.Point(220, 216);
            this.btn_Byte.Name = "btn_Byte";
            this.btn_Byte.Size = new System.Drawing.Size(75, 23);
            this.btn_Byte.TabIndex = 2;
            this.btn_Byte.Text = "Byte Code";
            this.btn_Byte.UseVisualStyleBackColor = true;
            this.btn_Byte.Click += new System.EventHandler(this.btn_Byte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 267);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_Frekans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Micro Stuffs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Prescaler1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Timers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_settimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Periyot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Timer;
        private System.Windows.Forms.ComboBox cb_Prescaler2;
        private System.Windows.Forms.ComboBox cb_Postscaler;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.ComboBox cb_Prescaler3;
        private System.Windows.Forms.TextBox txt_PR2;
        private System.Windows.Forms.Label lbl_PR2;
        private System.Windows.Forms.TextBox txt_mhz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Frekans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Byte;
        private System.Windows.Forms.Button btn_Pic;
        private System.Windows.Forms.TextBox txt_Codes;
    }
}

