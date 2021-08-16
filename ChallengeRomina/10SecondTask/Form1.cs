using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10SecondTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        void taskTenSeconds()
        {
            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(10000);
                System.Diagnostics.Debug.WriteLine("Aca estoy, despues de 10 segundos.");
            });
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            taskTenSeconds();
        }
    }
}
