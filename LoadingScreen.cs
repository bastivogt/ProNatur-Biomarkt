using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class loadingScreen : Form
    {

        int loadingbarValue;

        public loadingScreen()
        {
            InitializeComponent();
        }



        private void loadingScreen_Load(object sender, EventArgs e)
        {
            
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingbarValue += 1;
            loadingProgressbar.Value = loadingbarValue;
            lblLoadingProgress.Text = $"{loadingbarValue}%";
            Timer s = sender as Timer;
            if(loadingbarValue >= loadingProgressbar.Maximum)
            {
                s.Stop();
            }
        }
    }
}
