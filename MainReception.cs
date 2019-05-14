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
    public partial class MainReception : Form
    {
        public MainReception()
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

        private void bloodBank1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;
            addPatient1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Height = button2.Height;
            panel2.Top = button2.Top;
            bodyMassIndex1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Height = button3.Height;
            panel2.Top = button3.Top;
            bPmonitory1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Height = button4.Height;
            panel2.Top = button4.Top;
            bloodBank1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Height = button5.Height;
            panel2.Top = button5.Top;
            pharmacy1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Height = button7.Height;
            panel2.Top = button7.Top;
            bloodCholesterol1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Height = button6.Height;
            panel2.Top = button6.Top;
            patientData1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Height = button8.Height;
            panel2.Top = button8.Top;
            absentess1.BringToFront();
        }

        private void MainReception_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
