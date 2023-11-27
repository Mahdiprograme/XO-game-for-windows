using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xo
{
    public partial class Form1 : Form
    {
        Color lineColor = Color.Black;
        Color xColor = Color.Red;
        Color oColor = Color.Blue;


        char nobat = 'x';
        List<int> xIndexes = new List<int>();
        List<int> oIndexes = new List<int>();
        SplashScreen screen = new SplashScreen();
        settings settingScreen = new settings();

        public Form1()
        {
            InitializeComponent();
            
            screen.Show();
            
            splashTimer.Start();
        }

        private void Reset()
        {
            nobat = 'x';
            xIndexes = new List<int>();
            oIndexes = new List<int>();
            index0_btn.Text = "";
            index1_btn.Text = "";
            index2_btn.Text = "";
            index3_btn.Text = "";
            index4_btn.Text = "";
            index5_btn.Text = "";
            index6_btn.Text = "";
            index7_btn.Text = "";
            index8_btn.Text = "";
            label1.BackColor = lineColor;
            label2.BackColor = lineColor;
            label3.BackColor = lineColor;
            label5.BackColor = lineColor;
            gameTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer.Start();
            

        }

        private void closeGame_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void index0_btn_Click(object sender, EventArgs e)
        {
            if(index0_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index0_btn.Text = "X";
                    xIndexes.Add(1);
                    nobat = 'o';
                    index0_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index0_btn.Text = "O";
                    oIndexes.Add(1);
                    nobat = 'x';
                    index0_btn.ForeColor = oColor;
                }
            }
        }

        private void index1_btn_Click(object sender, EventArgs e)
        {
           if(index1_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index1_btn.Text = "X";
                    xIndexes.Add(2);
                    nobat = 'o';
                    index1_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index1_btn.Text = "O";
                    oIndexes.Add(2);
                    nobat = 'x';
                    index1_btn.ForeColor = oColor;
                }
            }
        }

        private void index2_btn_Click(object sender, EventArgs e)
        {
           if(index2_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index2_btn.Text = "X";
                    xIndexes.Add(3);
                    nobat = 'o';
                    index2_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index2_btn.Text = "O";
                    oIndexes.Add(3);
                    nobat = 'x';
                    index2_btn.ForeColor = oColor;
                }
            }
        }

        private void index3_btn_Click(object sender, EventArgs e)
        {
           if(index3_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index3_btn.Text = "X";
                    xIndexes.Add(4);
                    nobat = 'o';
                    index3_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index3_btn.Text = "O";
                    oIndexes.Add(4);
                    nobat = 'x';
                    index3_btn.ForeColor = oColor;
                }
            }
        }

        private void index4_btn_Click(object sender, EventArgs e)
        {
            if(index4_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index4_btn.Text = "X";
                    xIndexes.Add(5);
                    nobat = 'o';
                    index4_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index4_btn.Text = "O";
                    oIndexes.Add(5);
                    nobat = 'x';
                    index4_btn.ForeColor = oColor;
                }
            }
        }

        private void index5_btn_Click(object sender, EventArgs e)
        {
            if(index5_btn.Text == "") {
                if (nobat == 'x')
                {
                    index5_btn.Text = "X";
                    xIndexes.Add(6);
                    nobat = 'o';
                    index5_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index5_btn.Text = "O";
                    oIndexes.Add(6);
                    nobat = 'x';
                    index5_btn.ForeColor = oColor;
                }
            }
        }

        private void index6_btn_Click(object sender, EventArgs e)
        {
            if(index6_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index6_btn.Text = "X";
                    xIndexes.Add(7);
                    nobat = 'o';
                    index6_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index6_btn.Text = "O";
                    oIndexes.Add(7);
                    nobat = 'x';
                    index6_btn.ForeColor = oColor;
                }
            }
        }

        private void index7_btn_Click(object sender, EventArgs e)
        {
            if(index7_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index7_btn.Text = "X";
                    xIndexes.Add(8);
                    nobat = 'o';
                    index7_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index7_btn.Text = "O";
                    oIndexes.Add(8);
                    nobat = 'x';
                    index7_btn.ForeColor = oColor;
                }
            }
        }

        private void index8_btn_Click(object sender, EventArgs e)
        {
            if(index8_btn.Text == "")
            {
                if (nobat == 'x')
                {
                    index8_btn.Text = "X";
                    xIndexes.Add(9);
                    nobat = 'o';
                    index8_btn.ForeColor = xColor;
                }
                else if (nobat == 'o')
                {
                    index8_btn.Text = "O";
                    oIndexes.Add(9);
                    nobat = 'x';
                    index8_btn.ForeColor = oColor;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            char winner = 'c';
            bool[] x = new bool[9];
            bool[] o = new bool[9];
            for (int i = 0; i <= 8;)
            {
                x[i] = xIndexes.Contains(i + 1);
                i++;
            }
            for (int i = 0; i <= 8;)
            {
                o[i] = oIndexes.Contains(i + 1);
                i++;
            }

            if (x[0] && x[1] && x[2])
                winner = 'x';
            else if (x[3] && x[4] && x[5])
                winner = 'x';
            else if (x[6] && x[7] && x[8])
                winner = 'x';
            else if (x[0] && x[3] && x[6])
                winner = 'x';
            else if (x[1] && x[4] && x[7])
                winner = 'x';
            else if (x[2] && x[5] && x[8])
                winner = 'x';
            else if (x[0] && x[4] && x[8])
                winner = 'x';
            else if (x[2] && x[4] && x[6])
                winner = 'x';

            if (o[0] && o[3] && o[6])
                winner = 'o';
            else if (o[1] && o[4] && o[7])
                winner = 'o';
            else if (o[2] && o[5] && o[8])
                winner = 'o';
            else if (o[0] && o[4] && o[8])
                winner = 'o';
            else if (o[2] && o[4] && o[6])
                winner = 'o';
            else if (o[0] && o[1] && o[2])
                winner = 'o';
            else if (o[3] && o[4] && o[5])
                winner = 'o';
            else if (o[6] && o[7] && o[8])
                winner = 'o';

            bool condition =
                index0_btn.Text != "" && index1_btn.Text != "" &&
                index2_btn.Text != "" && index3_btn.Text != "" &&
                index4_btn.Text != "" && index5_btn.Text != "" &&
                index6_btn.Text != "" && index7_btn.Text != "" &&
                index8_btn.Text != "";

            if (winner == 'x' || winner == 'o')
            {
                gameTimer.Stop();
                WinMessage win = new WinMessage(winner);
                win.ShowDialog();
                Reset();
            }

            else if (condition)
            {
                gameTimer.Stop();
                MessageBox.Show("Equal!");
                Reset();
            }
        }

        private void retryGameBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            screen.Close();
            this.Opacity = 100;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Are You Sure About That?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingScreen.ShowDialog();
            if (settingScreen.isChanged)
            {
                lineColor = settingScreen.lineColor;
                xColor = settingScreen.Xcolor;
                oColor = settingScreen.Ocolor;
                Reset();
            }
        }
    }
}
