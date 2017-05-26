namespace РГЗ
{
    partial class Extract_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extract_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Back = new System.Windows.Forms.ToolStripButton();
            this.btn_Share = new System.Windows.Forms.ToolStripButton();
            this.btn_Decrypt = new System.Windows.Forms.ToolStripButton();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.txt_Decrypt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_Number = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.txt_Decrypt);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txt_Number);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
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
            this.btn_Decrypt,
            this.btn_Reset});
            this.toolStrip1.Location = new System.Drawing.Point(6, 181);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(231, 50);
            this.toolStrip1.TabIndex = 6;
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
            // btn_Decrypt
            // 
            this.btn_Decrypt.AutoSize = false;
            this.btn_Decrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Decrypt.Image = ((System.Drawing.Image)(resources.GetObject("btn_Decrypt.Image")));
            this.btn_Decrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(40, 40);
            this.btn_Decrypt.Text = "Click there for extracting message from choosen image";
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
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
            // txt_Decrypt
            // 
            // 
            // 
            // 
            this.txt_Decrypt.CustomButton.Image = null;
            this.txt_Decrypt.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txt_Decrypt.CustomButton.Name = "";
            this.txt_Decrypt.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_Decrypt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Decrypt.CustomButton.TabIndex = 1;
            this.txt_Decrypt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Decrypt.CustomButton.UseSelectable = true;
            this.txt_Decrypt.CustomButton.Visible = false;
            this.txt_Decrypt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_Decrypt.Lines = new string[0];
            this.txt_Decrypt.Location = new System.Drawing.Point(6, 116);
            this.txt_Decrypt.MaxLength = 32767;
            this.txt_Decrypt.Multiline = true;
            this.txt_Decrypt.Name = "txt_Decrypt";
            this.txt_Decrypt.PasswordChar = '\0';
            this.txt_Decrypt.ReadOnly = true;
            this.txt_Decrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Decrypt.SelectedText = "";
            this.txt_Decrypt.SelectionLength = 0;
            this.txt_Decrypt.SelectionStart = 0;
            this.txt_Decrypt.ShortcutsEnabled = true;
            this.txt_Decrypt.Size = new System.Drawing.Size(231, 31);
            this.txt_Decrypt.TabIndex = 5;
            this.txt_Decrypt.UseSelectable = true;
            this.txt_Decrypt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Decrypt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(169, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Извлеченное сообщение:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Введите число символов:";
            // 
            // txt_Number
            // 
            // 
            // 
            // 
            this.txt_Number.CustomButton.Image = null;
            this.txt_Number.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txt_Number.CustomButton.Name = "";
            this.txt_Number.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txt_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Number.CustomButton.TabIndex = 1;
            this.txt_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Number.CustomButton.UseSelectable = true;
            this.txt_Number.CustomButton.Visible = false;
            this.txt_Number.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_Number.Lines = new string[0];
            this.txt_Number.Location = new System.Drawing.Point(6, 50);
            this.txt_Number.MaxLength = 32767;
            this.txt_Number.Multiline = true;
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.PasswordChar = '\0';
            this.txt_Number.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Number.SelectedText = "";
            this.txt_Number.SelectionLength = 0;
            this.txt_Number.SelectionStart = 0;
            this.txt_Number.ShortcutsEnabled = true;
            this.txt_Number.Size = new System.Drawing.Size(231, 31);
            this.txt_Number.TabIndex = 0;
            this.txt_Number.UseSelectable = true;
            this.txt_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Number.TextChanged += new System.EventHandler(this.txt_Number_TextChanged);
            this.txt_Number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Number_KeyDown);
            this.txt_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(293, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 216);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(293, 246);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(234, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressBar1.TabIndex = 4;
            this.metroProgressBar1.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(337, 278);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(164, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Пожалуйста, подождите...";
            this.metroLabel4.Visible = false;
            // 
            // Extract_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Extract_Form";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Извлечение";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroTextBox txt_Decrypt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Share;
        private System.Windows.Forms.ToolStripButton btn_Decrypt;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ToolStripButton btn_Back;
    }
}