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
using System.Drawing.Imaging;

namespace РГЗ
{
    public partial class Hide_Form : MetroForm
    {
        string filter = "Image Files (*.jpg)|*.jpg|Image Files (.bmp)|*.bmp";
        string adress = String.Empty;
        Bitmap resultImage;
        DCT transforms = new DCT();
        string message;
        byte[,] mas_byte;
        List<byte[,]> mas_sepparated;
        List<double[,]> mas_dct;
        List<double[,]> mas_infiltrated;
        List<double[,]> mas_idct;
        List<byte[,]> mas_new_sepparated;
        byte[,] mas_new_byte;

        List<Thread> threads = new List<Thread>();


        public class ContainerFlaw : Exception//исключение
        {
            public ContainerFlaw(string message) : base(message)
            {

            }
        }

        public void DoEncrypt()
        {
            try
            {
                ImageMaker image = new ImageMaker(adress);
                mas_byte = image.ArrayFilling();
                mas_sepparated = image.ArraySeparation(mas_byte);

                if (mas_sepparated.Count < message.Length * 8)
                {
                    metroProgressBar1.Visible = false;
                    metroLabel4.Visible = false;
                    throw new ContainerFlaw("The message length is too large for the container");
                }

                mas_dct = transforms.DisCosTrans(mas_sepparated);
                mas_infiltrated = transforms.Infiltration(mas_dct, message, 4, 5, 5, 4);
                mas_idct = transforms.RevDisCosTrans(mas_infiltrated);
                mas_new_sepparated = transforms.Normalize(mas_idct);
                mas_new_byte = transforms.Add(mas_new_sepparated, image.Width, image.Height);
                resultImage = image.Introduction(mas_new_byte);
                metroProgressBar1.Visible = false;
                metroLabel4.Visible = false;
                btn_Share.Enabled = true;
                btn_Encrypt.Enabled = true;
                btn_Save.Enabled = true;
            }
            catch (ContainerFlaw ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public Hide_Form()
        {
            InitializeComponent();
            btn_Encrypt.Enabled = false;
            btn_Save.Enabled = false;
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
                btn_Encrypt.Enabled = true;
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Encrypt.Text == String.Empty)
                {
                    throw new ContainerFlaw("Please, enter a hidding message");
                }
                metroProgressBar1.Visible = true;
                metroLabel4.Visible = true;
                btn_Share.Enabled = false;
                btn_Encrypt.Enabled = false;
                message = txt_Encrypt.Text;
                ThreadStart deleg = new ThreadStart(DoEncrypt);
                Thread thr = new Thread(deleg);
                threads.Add(thr);
                thr.Start();
            }
            catch (ContainerFlaw ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            string result_adress;
            save.DefaultExt = ".jpg";

            if (save.ShowDialog() == DialogResult.OK)
            {
                result_adress = save.FileName;

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                //System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                //System.Drawing.Imaging.Encoder myEncoder2 = System.Drawing.Imaging.Encoder.Compression;

                //EncoderParameters myEncoderParameters = new EncoderParameters(2);

                //EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                //EncoderParameter myEncoderParameter2 = new EncoderParameter(myEncoder2,(long)EncoderValue.CompressionNone);

                //myEncoderParameters.Param[0] = myEncoderParameter;
                //myEncoderParameters.Param[1] = myEncoderParameter2;


                //resultImage.Save(result_adress, jpgEncoder, myEncoderParameters);
                resultImage.Save(result_adress);
            }

        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            foreach (Thread t in threads)
            {
                t.Abort();
            }

            metroProgressBar1.Visible = false;
            btn_Share.Enabled = true;
            btn_Encrypt.Enabled = false;
            btn_Save.Enabled = false;
            pictureBox1.Image = null;
            txt_Encrypt.Text = String.Empty;
            metroLabel4.Hide();
        }

        private void txt_Encrypt_TextChanged(object sender, EventArgs e)
        {
            metroLabel3.Text = txt_Encrypt.Text.Length.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Activate();
        }

    }
}
