using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_HMS
{
    public partial class ReceptionLogin : UserControl
    {
        public ReceptionLogin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainReception mr = new MainReception();
            mr.Show();
            this.Hide();
        }
    }
}
