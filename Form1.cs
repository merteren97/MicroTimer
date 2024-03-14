using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroTimerStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Combobox Select First Bitch (Cuz Why Nut ?)
            cb_Timers.SelectedIndex = 0;
            cb_Prescaler1.SelectedIndex = 0;
            cb_Prescaler2.SelectedIndex = 0;
            cb_Prescaler3.SelectedIndex = 0;
            cb_Postscaler.SelectedIndex = 0;

        }

        private void cb_Timers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Timers.SelectedIndex == 0)
            {
                cb_Prescaler1.Visible = true;
                cb_Prescaler2.Visible = false;
                cb_Prescaler3.Visible = false;
                cb_Postscaler.Visible = false;
                lbl_post.Visible = false;
                lbl_PR2.Visible = false;
                txt_PR2.Visible = false;
                this.Height = 306;
            }
            else if (cb_Timers.SelectedIndex == 1)
            {
                cb_Prescaler1.Visible = false;
                cb_Prescaler2.Visible = true;
                cb_Prescaler3.Visible = false;
                cb_Postscaler.Visible = false;
                lbl_post.Visible = false;
                lbl_PR2.Visible = false;
                txt_PR2.Visible = false;
                this.Height = 306;
            }
            else if (cb_Timers.SelectedIndex == 2)
            {
                cb_Prescaler1.Visible = false;
                cb_Prescaler2.Visible = false;
                cb_Prescaler3.Visible = true;
                cb_Postscaler.Visible = true;
                lbl_post.Visible = true;
                lbl_PR2.Visible = true;
                txt_PR2.Visible = true;
                this.Height = 364;
            }

        }

        private void btn_Timer_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            if (cb_Timers.SelectedIndex == 0) // Timer 0
            {
                // Periyot = (256 - TMR0) x Prescaler
                sonuc = ((256 - double.Parse(txt_settimer.Text)) * double.Parse(cb_Prescaler1.Text)) * (1/(double.Parse(txt_mhz.Text)/4));
                sonuc /= 1000;
                lbl_Periyot.Text = sonuc.ToString() + " ms";
            }
            else if (cb_Timers.SelectedIndex == 1) // Timer 1
            {
                // Periyot = (65536 - TMR1) x Prescaler
                sonuc = ((65536 - double.Parse(txt_settimer.Text)) * double.Parse(cb_Prescaler2.Text)) * (1/(double.Parse(txt_mhz.Text)/4));
                sonuc /= 1000;
                lbl_Periyot.Text = sonuc.ToString() + " ms";
            }
            else if (cb_Timers.SelectedIndex == 2) // Timer 2
            {
                // Tof = Tosc x Prescaler x (PR2 + 1) x Postcaler
                sonuc = (1/(double.Parse(txt_mhz.Text)/4)) * double.Parse(cb_Prescaler3.Text) * (double.Parse(txt_PR2.Text)+1) * double.Parse(cb_Postscaler.Text);
                sonuc /= 1000;
                double fre = 1 / (sonuc/1000);
                lbl_Periyot.Text = sonuc.ToString() + " ms";
                lbl_Frekans.Text = fre.ToString() + " Hz";
            }
        }

        private void btn_Pic_Click(object sender, EventArgs e)
        {
            txt_Codes.Text = "";
            if (cb_Timers.SelectedIndex == 0) // TIMER0
            {
                txt_Codes.Text += "seup_timer0(RTCC_INTERNAL | RTCC_DIV_" + cb_Prescaler2.Text + ");\r\n";
                txt_Codes.Text += "seup_timer0(EXT_L_TO_H | RTCC_DIV_" + cb_Prescaler2.Text + "); //Timer0 External girişten yükselen kenarda sayacak.\r\n";
            }
            else if (cb_Timers.SelectedIndex == 1) // TIMER1
            {
                txt_Codes.Text += "seup_timer1(T1_INTERNAL | T1_DIV_BY_"+ cb_Prescaler2.Text + ");\r\n";
            }
            else if (cb_Timers.SelectedIndex == 2) // TIMER2
            {
                txt_Codes.Text += "#byte TIMER0 = 0x01\r\n";
            }
        }
        private void btn_Byte_Click(object sender, EventArgs e)
        {
            txt_Codes.Text = "";
            if(cb_Timers.SelectedIndex == 0) // TIMER0
            {
                txt_Codes.Text += "#byte OPTION_REG = 0x81\r\n" +
                    "#byte TIMER0 = 0x01\r\n";
                string bit = "";
                switch (cb_Prescaler1.SelectedIndex)
                {
                    case 0:
                        bit = "11000000"; // Son bit timer açıp kapama
                        break;
                    case 1:
                        bit = "11000001";
                        break;
                    case 2:
                        bit = "11000010";
                        break;
                    case 3:
                        bit = "11000011";
                        break;
                    case 4:
                        bit = "11000100";
                        break;
                    case 5:
                        bit = "11000101";
                        break;
                    case 6:
                        bit = "11000110";
                        break;
                    case 7:
                        bit = "11000111";
                        break;
                }
                txt_Codes.Text += "OPTION_REG = OPTION_REG & 0x" + Convert.ToInt32(bit, 2).ToString("X2") + " //Timer0 prescaler yükselen kenar\r\n";
            }
            else if(cb_Timers.SelectedIndex == 1) // TIMER1
            {
                txt_Codes.Text += "#byte T1CON = 0x10\r\n" +
                    "#byte TMR1L = 0x0E\r\n" +
                    "#byte TMR1H = 0x0F\r\n";
                string bit = "";
                switch (cb_Prescaler2.SelectedIndex)
                {
                    case 0:
                        bit = "00000101"; // Son bit timer açıp kapama
                        break;
                    case 1:
                        bit = "00010101";
                        break;
                    case 2:
                        bit = "00100101";
                        break;
                    case 3:
                        bit = "00110101";
                        break;
                }
                txt_Codes.Text += "T1CON = 0x" + Convert.ToInt32(bit,2).ToString("X2") + "; //Prescaler ayari, Senk yok.\r\n\r\n";
                txt_Codes.Text += "long time;\r\n" +
                    "time = ((time|TMR1H) <<8 )|TMR1L; //timer1 degerini time a at\r\n" +
                    "TMR1L = time;// time değişkenine\r\n" +
                    "TMR1H = (time >> 8);// timer1 değerini al\r\n"; 
            }
            else if (cb_Timers.SelectedIndex == 2) // TIMER2
            {
                txt_Codes.Text += "#byte T2CON = 0x12 //Timer2 Control Reg\r\n" +
                    "#byte TMR2 = 0x11 //Timer2 degeri tutan reg\r\n" +
                    "#byte PR2 = 0x92 //Timer2 Periyot\r\n";
                string bit = "0";
                int n = int.Parse(cb_Postscaler.Text) - 1; // 1 çıkıyoz çünkü ilk 1 değeri 0000 dan başlıyo
                int[] a = new int[4];
                for(int i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n /= 2;
                }
                for (int i = 3; i >= 0; --i)
                    bit += a[i].ToString();
                bit += "1"; // Timer2 ON

                //Prescaler değerleride ekleniyor.
                if (cb_Prescaler3.SelectedIndex == 0)
                    bit += "00";
                else if (cb_Prescaler3.SelectedIndex == 1)
                    bit += "01";
                else if (cb_Prescaler3.SelectedIndex == 2)
                    bit += "11"; // son bit önemli değil

                txt_Codes.Text += "//Binary Hali: 0b" + bit + "\r\n";
                txt_Codes.Text += "T2CON = 0x" + Convert.ToInt32(bit, 2).ToString("X2") + "; //Reg Ayarlari.\r\n";
                txt_Codes.Text += "PR2 = " + txt_PR2.Text + "; //Periyot ayari.\r\n";
            }
        }
    }
}
