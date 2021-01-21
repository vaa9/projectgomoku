using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectgomoku
{
    public partial class winner : Form
    {
        public winner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playagainbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoMoKu ob = new GoMoKu();
            ob.Show();
        }

        private void exitbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
