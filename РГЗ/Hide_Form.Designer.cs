using System;

namespace РГЗ
{
    partial class Hide_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hide_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Back = new System.Windows.Forms.ToolStripButton();
            this.btn_Share = new System.Windows.Forms.ToolStripButton();
            this.btn_Encrypt = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.txt_Encrypt = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(293, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.txt_Encrypt);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(144, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(16, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(132, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Number of symbols: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Enter a hidding message:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Back,
            this.btn_Share,
            this.btn_Encrypt,
            this.btn_Save,
            this.btn_Reset});
            this.toolStrip1.Location = new System.Drawing.Point(6, 181);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(251, 50);
            this.toolStrip1.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.AutoSize = false;
            this.btn_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(40, 40);
            this.btn_Back.Text = "Click there to go back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Share
            // 
            this.btn_Share.AutoSize = false;
            this.btn_Share.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Share.Image = ((System.Drawing.Image)(resources.GetObject("btn_Share.Image")));
            this.btn_Share.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Share.Name = "btn_Share";
            this.btn_Share.Size = new System.Drawing.Size(40, 40);
            this.btn_Share.Text = "Click there for choosing image in directory";
            this.btn_Share.Click += new System.EventHandler(this.btn_Share_Click_1);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.AutoSize = false;
            this.btn_Encrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Encrypt.Image = ((System.Drawing.Image)(resources.GetObject("btn_Encrypt.Image")));
            this.btn_Encrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(40, 40);
            this.btn_Encrypt.Text = "Click there for hiding message in choosen image";
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSize = false;
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(40, 40);
            this.btn_Save.Text = "CLick there for saving image in directory";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.AutoSize = false;
            this.btn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(40, 40);
            this.btn_Reset.Text = "Click there for reset settings";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Encrypt
            // 
            // 
            // 
            // 
            this.txt_Encrypt.CustomButton.Image = null;
            this.txt_Encrypt.CustomButton.Location = new System.Drawing.Point(162, 2);
            this.txt_Encrypt.CustomButton.Name = "";
            this.txt_Encrypt.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.txt_Encrypt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Encrypt.CustomButton.TabIndex = 1;
            this.txt_Encrypt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Encrypt.CustomButton.UseSelectable = true;
            this.txt_Encrypt.CustomButton.Visible = false;
            this.txt_Encrypt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_Encrypt.Lines = new string[0];
            this.txt_Encrypt.Location = new System.Drawing.Point(6, 64);
            this.txt_Encrypt.MaxLength = 32767;
            this.txt_Encrypt.Multiline = true;
            this.txt_Encrypt.Name = "txt_Encrypt";
            this.txt_Encrypt.PasswordChar = '\0';
            this.txt_Encrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Encrypt.SelectedText = "";
            this.txt_Encrypt.SelectionLength = 0;
            this.txt_Encrypt.SelectionStart = 0;
            this.txt_Encrypt.ShortcutsEnabled = true;
            this.txt_Encrypt.Size = new System.Drawing.Size(230, 70);
            this.txt_Encrypt.Style = MetroFramework.MetroColorStyle.White;
            this.txt_Encrypt.TabIndex = 0;
            this.txt_Encrypt.UseSelectable = true;
            this.txt_Encrypt.UseStyleColors = true;
            this.txt_Encrypt.WaterMarkColor = System.Drawing.Color.Black;
            this.txt_Encrypt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Encrypt.TextChanged += new System.EventHandler(this.txt_Encrypt_TextChanged);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.metroProgressBar1.Location = new System.Drawing.Point(293, 246);
            this.metroProgressBar1.MarqueeAnimationSpeed = 20;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(234, 23);
            this.metroProgressBar1.Step = 50;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressBar1.TabIndex = 2;
            this.metroProgressBar1.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(378, 278);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Please wait...";
            this.metroLabel4.Visible = false;
            // 
            // Hide_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Hide_Form";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Hide Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Share_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Encrypt;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Encrypt;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.ToolStripButton btn_Share;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ToolStripButton btn_Back;
    }
}