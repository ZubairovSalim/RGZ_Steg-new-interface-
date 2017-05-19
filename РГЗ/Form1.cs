using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Threading;

namespace РГЗ
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Hide_Form H_Form = new Hide_Form();
            H_Form.Owner = this;
            H_Form.Show();
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            Extract_Form E_Form = new Extract_Form();
            E_Form.Owner = this;
            E_Form.Show();
        }
    }
}
