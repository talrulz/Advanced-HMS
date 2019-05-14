using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_HMS
{
    public partial class AdminDepartment : Form
    {
        public AdminDepartment()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void AdminDepartment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;
            addEmployee1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            absentee1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Height = button3.Height;
            panel2.Top = button3.Top;
            receptionRegister1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Height = button4.Height;
            panel2.Top = button4.Top;
            employeeInfo1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Height = button5.Height;
            panel2.Top = button5.Top;
            receptionistInfo1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Height = button7.Height;
            panel2.Top = button7.Top;
            adminregisteration1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
