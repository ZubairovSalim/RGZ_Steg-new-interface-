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
    public partial class Extract_Form : MetroForm
    {
        string filter = "Image Files (*.jpg)|*.jpg|Image Files (.bmp)|*.bmp";
        string adress = String.Empty;
        DCT transforms = new DCT();
        string message;
        int mes_length;

        byte[,] mas2_byte;
        List<byte[,]> mas2_sepparated;
        List<double[,]> mas2_dct;

        List<Thread> threads = new List<Thread>();

        public delegate void Helper2(string s);

        public class ContainerFlaw : Exception//исключение
        {
            public ContainerFlaw(string message) : base(message)
            {

            }
        }

        public void DoDecrypt()
        {
            ImageMaker image1 = new ImageMaker(adress);
            mes_length = Convert.ToInt32(txt_Number.Text);
            mas2_byte = image1.ArrayFilling();
            mas2_sepparated = image1.ArraySeparation(mas2_byte);
            mas2_dct = transforms.DisCosTrans(mas2_sepparated);
            string mes = transforms.Extraction(mas2_dct, 4, 5, 5, 4, mes_length);
            DecryptHelp(mes);
            //txt_Decrypt.Text = mes;
            //metroProgressBar1.Visible = false;
            //metroLabel4.Visible = false;
            //btn_Share.Enabled = true;
            //btn_Decrypt.Enabled = true;
        }

        public void DecryptHelp(string str)
        {
            if (this.metroProgressBar1.InvokeRequired)
            {
                Helper2 d1 = new Helper2(DecryptHelp);
                this.Invoke(d1, new object[] { str });
            }
            else
            {
                txt_Decrypt.Text = str;
                metroProgressBar1.Visible = false;
                metroLabel4.Visible = false;
                btn_Share.Enabled = true;
                btn_Decrypt.Enabled = true;
            }
        }

        public Extract_Form()
        {
            InitializeComponent();
            btn_Decrypt.Enabled = false;
        }

        private void btn_Share_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = filter;
            if (opn.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = new Bitmap(opn.FileName);
                adress = opn.FileName;
            }
            if (adress != String.Empty)
            {
                btn_Decrypt.Enabled = true;
            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Number.Text == String.Empty)
                {
                    throw new ContainerFlaw("Please, enter number of symbols");
                }

                else if (Convert.ToInt32(txt_Number.Text) == 0)
                {
                    throw new ContainerFlaw("Length of message is too small");
                }

                metroProgressBar1.Visible = true;
                metroLabel4.Visible = true;
                btn_Share.Enabled = false;
                btn_Decrypt.Enabled = false;
                ThreadStart deleg1 = new ThreadStart(DoDecrypt);
                Thread thr1 = new Thread(deleg1);
                threads.Add(thr1);
                thr1.Start();
            }
            catch (ContainerFlaw ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            foreach (Thread t in threads)
            {
                t.Abort();
            }

            metroProgressBar1.Visible = false;
            btn_Decrypt.Enabled = false;
            pictureBox1.Image = null;
            txt_Number.Text = String.Empty;
            txt_Decrypt.Text = String.Empty;
            metroLabel4.Hide();
        }

        bool non = false;

        private void txt_Number_KeyDown(object sender, KeyEventArgs e)
        {
            char symb = (char)e.KeyData;
            if (e.KeyCode == Keys.OemMinus)
                non = true;
            if (char.IsNumber(symb) == false)
                non = true;
            if (e.KeyCode == Keys.Back)
                non = false;
        }

        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (non == true)
            {
                e.Handled = true;
                non = false;
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Activate();
        }

    }


}
