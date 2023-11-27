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
    public partial class settings : Form
    {
        public Color lineColor = Color.Black;
        public Color Xcolor = Color.Red;
        public Color Ocolor = Color.Blue;
        public bool isChanged = false;

        public settings()
        {
            InitializeComponent();
            LineColorLabel.BackColor = Color.Black;
            xColorLabel.BackColor = Color.Red;
            oColorLabel.BackColor = Color.Blue;
        }

        private void chooseLineColor_btn_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog.ShowDialog();
            if(d == DialogResult.OK)
            {
                lineColor = colorDialog.Color;
                LineColorLabel.BackColor = colorDialog.Color;
            }
        }

        private void chooseXcolor_btn_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {
                Xcolor = colorDialog1.Color;
                xColorLabel.BackColor = colorDialog1.Color;
            }
        }

        private void chooseOcolor_btn_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog2.ShowDialog();
            if(d == DialogResult.OK)
            {
                Ocolor = colorDialog2.Color;
                oColorLabel.BackColor = colorDialog2.Color;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are You Sure To Cancel Your Changes?", "Cancel Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                lineColor = Color.White; 
                Xcolor = Color.White;
                Ocolor = Color.White;
                isChanged = false;
                this.Close();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are You Sure To Save Your Changes? Game Will be Restart", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                isChanged = true;
                this.Close();
            }
        }
    }
}
