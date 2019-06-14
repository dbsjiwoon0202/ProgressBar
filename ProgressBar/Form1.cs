using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        int Num = 0;
        string OrgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Num = 0;
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = lblStatus.Text;
        }

        private void BtnENd_Click(object sender, EventArgs e)
        {

        }

        private void ButbtnRunton1_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Num++;
            if(this.Num > 100)
            { this.Timer.Enabled = false;
                return;
            }
            this.pbStatus.Value = this.Num;
            this.lblStatus.Text = this.OrgStr + this.Num + "%";
        }
    }
}
