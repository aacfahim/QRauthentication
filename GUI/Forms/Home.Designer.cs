namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.status = new MaterialSkin.Controls.MaterialLabel();
            this.txtQRCode = new MaterialSkin.Controls.MaterialLabel();
            this.lastName = new MaterialSkin.Controls.MaterialLabel();
            this.firstName = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDevice
            // 
            this.cboDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(103, 116);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(234, 21);
            this.cboDevice.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Camera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Depth = 0;
            this.btnStart.Location = new System.Drawing.Point(405, 194);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = true;
            this.btnStart.Size = new System.Drawing.Size(114, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(505, 514);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = false;
            this.btnLogin.Size = new System.Drawing.Size(52, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.txtQRCode);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Location = new System.Drawing.Point(343, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 227);
            this.panel1.TabIndex = 6;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 176);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 25);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Status";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Depth = 0;
            this.status.Font = new System.Drawing.Font("Roboto", 11F);
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status.Location = new System.Drawing.Point(80, 176);
            this.status.MouseState = MaterialSkin.MouseState.HOVER;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(81, 21);
            this.status.TabIndex = 14;
            this.status.Text = "Awaiting...";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Depth = 0;
            this.txtQRCode.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtQRCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtQRCode.Location = new System.Drawing.Point(18, 105);
            this.txtQRCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(155, 19);
            this.txtQRCode.TabIndex = 13;
            this.txtQRCode.Tag = "ID";
            // 
            // lastName
            // 
            this.lastName.Depth = 0;
            this.lastName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastName.Location = new System.Drawing.Point(18, 59);
            this.lastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(183, 19);
            this.lastName.TabIndex = 12;
            this.lastName.Tag = "Last Name";
            // 
            // firstName
            // 
            this.firstName.Depth = 0;
            this.firstName.Font = new System.Drawing.Font("Roboto", 11F);
            this.firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstName.Location = new System.Drawing.Point(18, 25);
            this.firstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(131, 19);
            this.firstName.TabIndex = 11;
            this.firstName.Tag = "First Name";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cboDevice);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDevice;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnStart;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialFlatButton btnLogin;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel txtQRCode;
        private MaterialSkin.Controls.MaterialLabel lastName;
        private MaterialSkin.Controls.MaterialLabel firstName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel status;
    }
}