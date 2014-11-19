using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace binary_clock
{
    public partial class Form1 : Form
    {
        
        public Form1() {
            InitializeComponent();
        }

        private void time_Tick(object sender, EventArgs e) {
            
            click_time.Text = Convert.ToString(DateTime.Today.TimeOfDay);
            string val;
            System.Text.StringBuilder Result_hours = new System.Text.StringBuilder();
            foreach (byte Character in System.Text.ASCIIEncoding.ASCII.GetBytes(Convert.ToString(System.DateTime.Now.TimeOfDay.Hours ))) {
                Result_hours .Append(Convert.ToString(Character, 2).PadLeft(8, '0'));
                Result_hours .Append(" ");
            }
            val = Result_hours.ToString().Substring(0, Result_hours .ToString().Length - 1);
            lbl_time.Text = val;
            //Converts the time to binary and displayes them onto the form 
            System.Text.StringBuilder Result_minuits = new System.Text.StringBuilder();
            foreach (byte Character in System.Text.ASCIIEncoding.ASCII.GetBytes(Convert.ToString(System.DateTime.Now.TimeOfDay.Minutes ))) {
                Result_minuits.Append(Convert.ToString(Character, 2).PadLeft(8, '0'));
                Result_minuits.Append(" ");
            }
            val = Result_minuits.ToString().Substring(0, Result_minuits.ToString().Length - 1);
            lbl_time_bin_min.Text = val;

            System.Text.StringBuilder Result_sec = new System.Text.StringBuilder();
            foreach (byte Character in System.Text.ASCIIEncoding.ASCII.GetBytes(Convert.ToString(System.DateTime.Now.TimeOfDay.Seconds))) {
                Result_sec.Append(Convert.ToString(Character, 2).PadLeft(8, '0'));
                Result_sec.Append(" ");
            }
            val = Result_sec.ToString().Substring(0, Result_sec.ToString().Length - 1);
            lbl_time_bin_sec.Text = val;


            lbl_time_dec.Text = Convert.ToString(System.DateTime.Now.TimeOfDay )  ;
            int i_sec = System.DateTime.Now.TimeOfDay.Seconds;
            int i_min = System.DateTime.Now.TimeOfDay.Minutes;
            int i_hour = System.DateTime.Now.TimeOfDay.Hours;
            //These are integers used to costruct the pie chart's 
            
            //Img_clock.CreateGraphics().DrawLine(Pens.Red, i_sec, 160, i_sec *20 , i_sec^i_sec );
            //Img_clock.CreateGraphics().Flush();

           
            Img_clock.Refresh(); //Rereshes the clock to clear the graphics on every clock update
                 
            if (i_sec == 0) {
                Img_clock.Refresh();//Refreshes the clock graphics for every minute that passes 
            }

            //if (chk_mil_min.Checked == true) {
            //    //Img_clock.CreateGraphics().DrawPie(Pens.Red, 78,78, 175, 175, 270 , i_min *6);
            //    Img_clock.CreateGraphics().DrawPie(Pens.Red, 65,65, 200, 200, 270 , i_min *6);
            //}
            
            if (chk_mil_hour.Checked == true) {
                //Convets the 24 hour numbers down to 12 hour to make the scale of the hour pie chart correct
              
                if (i_hour == 13){
                    i_hour = 1;
                }
                if (i_hour == 14) {
                    i_hour = 2;
                }
                if (i_hour == 15) {
                    i_hour = 3;
                }
                if (i_hour == 16) {
                    i_hour = 4;
                }
                if (i_hour == 17) {
                    i_hour = 5;
                }
                if (i_hour == 18) {
                    i_hour = 6;
                }
                if (i_hour == 19) {
                    i_hour = 7;
                }
                if (i_hour == 20) {
                    i_hour = 8;
                }
                if (i_hour == 21) {
                    i_hour = 9;
                }
                if (i_hour == 22) {
                    i_hour = 10;
                }
                if (i_hour == 23) {
                    i_hour = 11;
                }
                if (i_hour == 24) {
                    i_hour = 12;
                }
                Img_clock.CreateGraphics().DrawPie(Pens.Green, 90, 90, 150, 150, 270  , i_hour * 30 + i_min /2);  
            }

            Img_clock.CreateGraphics().DrawPie(Pens.Blue, 65, 65, 200, 200, 270, i_sec * 6);
            if (chk_mil_min.Checked == true) {
                //Img_clock.CreateGraphics().DrawPie(Pens.Red, 78,78, 175, 175, 270 , i_min *6);
                Img_clock.CreateGraphics().DrawPie(Pens.Red, 65, 65, 200, 200, 270, i_min * 6);
            }
            lbl_ticks.Text = Convert.ToString("Day of week: " + System.DateTime.Now.DayOfWeek);
            lbl_month.Text = Convert.ToString("Month " + System.DateTime.Today.Month);
            lbl_day.Text = Convert.ToString("day " + System.DateTime.Now.Day);
            lbl_day_year.Text = Convert.ToString ("day of year " + System.DateTime.Now.DayOfYear );
            int i = 0;
           
            //while (i != 320){
            //    i = i + 10;
            //    Img_clock.CreateGraphics().DrawLine(Pens.Gray, 1, i, 360, i);
            //    Img_clock.CreateGraphics().DrawLine(Pens.Gray, i,0,i,360);
            //}
          }
      
        private void Form1_Load(object sender, EventArgs e) {
            string ans;
            Environment.SetEnvironmentVariable("%LittleTecWorkingDirectory%", "C:\\LT");
            tim_show.Start();
            
           // ans = Convert.ToString ( System.Windows.Forms.MessageBox.Show ("hello", "bob", MessageBoxButtons.OKCancel ));
          
           
        }

        private void cmd_about_Click(object sender, EventArgs e) {
           
            
            System.Windows.Forms.MessageBox.Show("Little Tec's Binary clock ", "tic toc", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e) {
            //this.Hide();
            tim_hide.Start();
        }

        private void nfi_tray_MouseDoubleClick(object sender, MouseEventArgs  e) {
            if (this.Visible == true) {
                tim_hide.Start();
            }
            else {
                tim_show.Start();
            }
           // this.Show();
            //right_click.Show();
            //System.Windows.Forms.MessageBox.Show   (Convert.ToString(Environment.GetEnvironmentVariable ("%LittleTecWorkingDirectory%")));
        }

        private void right_click_Opening(object sender, CancelEventArgs e) {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void click_time_Click(object sender, EventArgs e) {
            this.Width = 230;
            Img_clock.Left = 0;
        }

        private void tim_hide_Tick(object sender, EventArgs e) {
            tim_show.Stop();
            this.Opacity = this.Opacity -0.1;
            if (this.Opacity == 0) {
                tim_hide.Stop();
                this.Visible = false;
            }
        }

        private void tim_show_Tick(object sender, EventArgs e) {
            tim_hide.Stop();
            this.Visible = true;
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity == 0) {
                tim_show.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            
        }
        
    }
}
