using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAsenkronDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnProcess1_Click(object sender, EventArgs e)
        {
            await ASenkron();
        }

        private async void tnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test1");
            MessageBox.Show((await Don(1000, 10000)).ToString());
            MessageBox.Show("Test2");
        }

        Task<double> Don(double BaslangicDegeri, double BitisDegeri)
        {
            Task<double> islem = Task.Run<double>(() =>
            {
                while (true)
                {
                    if (BaslangicDegeri == BitisDegeri)
                        break;
                    label1.Text = BaslangicDegeri.ToString();
                    BaslangicDegeri++;
                }
                return BaslangicDegeri;
            });

            return islem;
        }

        Task ASenkron()
        {
            return Task.Run(() =>
            {
                MessageBox.Show("Test1");
                Don(1000, 10000);
                MessageBox.Show("Test2");
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
