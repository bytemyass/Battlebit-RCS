using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBR
{
    public partial class BBR : Form
    {
        public static bool active = false;
        public static int smoothing = 6;
        public static int sens = 100;
        public static int fov = 90;
        public static string selection = "AK74";
        public BBR()
        {
            InitializeComponent();
        }

        private void FOV_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
     
        private void SMOOTHING_ValueChanged(object sender, EventArgs e)
        {
            smoothing = (int)SMOOTHING.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                active = true;
            }
            else
            {
                active = false;
            }
        }

        private void WEAPONSELECT_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = WEAPONSELECT.SelectedItem.ToString();
        }

        private void SENS_ValueChanged(object sender, EventArgs e)
        {
            sens = (int)SMOOTHING.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
