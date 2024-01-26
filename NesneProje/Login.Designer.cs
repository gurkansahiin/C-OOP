namespace NesneProje
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GirisButton = new Guna.UI2.WinForms.Guna2Button();
            this.DuyurularButton = new Guna.UI2.WinForms.Guna2Button();
            this.KullanTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Sifreetb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(452, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "SPOR MERKEZİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GirisButton
            // 
            this.GirisButton.BorderRadius = 20;
            this.GirisButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GirisButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GirisButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GirisButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GirisButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.GirisButton.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.GirisButton.ForeColor = System.Drawing.Color.White;
            this.GirisButton.Location = new System.Drawing.Point(379, 295);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(166, 45);
            this.GirisButton.TabIndex = 8;
            this.GirisButton.Text = "Giris";
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // DuyurularButton
            // 
            this.DuyurularButton.BorderRadius = 20;
            this.DuyurularButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DuyurularButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DuyurularButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DuyurularButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DuyurularButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.DuyurularButton.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.DuyurularButton.ForeColor = System.Drawing.Color.White;
            this.DuyurularButton.Location = new System.Drawing.Point(573, 295);
            this.DuyurularButton.Name = "DuyurularButton";
            this.DuyurularButton.Size = new System.Drawing.Size(173, 45);
            this.DuyurularButton.TabIndex = 9;
            this.DuyurularButton.Text = "Duyurular";
            this.DuyurularButton.Click += new System.EventHandler(this.DuyurularButton_Click);
            // 
            // KullanTb
            // 
            this.KullanTb.AcceptsReturn = false;
            this.KullanTb.AcceptsTab = false;
            this.KullanTb.AnimationSpeed = 200;
            this.KullanTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.KullanTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.KullanTb.AutoSizeHeight = true;
            this.KullanTb.BackColor = System.Drawing.Color.Transparent;
            this.KullanTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KullanTb.BackgroundImage")));
            this.KullanTb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.KullanTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.KullanTb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.KullanTb.BorderColorIdle = System.Drawing.Color.Silver;
            this.KullanTb.BorderRadius = 30;
            this.KullanTb.BorderThickness = 1;
            this.KullanTb.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.KullanTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.KullanTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KullanTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.KullanTb.DefaultText = "";
            this.KullanTb.FillColor = System.Drawing.Color.White;
            this.KullanTb.ForeColor = System.Drawing.Color.Black;
            this.KullanTb.HideSelection = true;
            this.KullanTb.IconLeft = null;
            this.KullanTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.KullanTb.IconPadding = 10;
            this.KullanTb.IconRight = null;
            this.KullanTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.KullanTb.Lines = new string[0];
            this.KullanTb.Location = new System.Drawing.Point(379, 116);
            this.KullanTb.MaxLength = 32767;
            this.KullanTb.MinimumSize = new System.Drawing.Size(1, 1);
            this.KullanTb.Modified = false;
            this.KullanTb.Multiline = false;
            this.KullanTb.Name = "KullanTb";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.White;
            this.KullanTb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.White;
            this.KullanTb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.KullanTb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.KullanTb.OnIdleState = stateProperties4;
            this.KullanTb.Padding = new System.Windows.Forms.Padding(3);
            this.KullanTb.PasswordChar = '\0';
            this.KullanTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.KullanTb.PlaceholderText = "Kullanici adı";
            this.KullanTb.ReadOnly = false;
            this.KullanTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KullanTb.SelectedText = "";
            this.KullanTb.SelectionLength = 0;
            this.KullanTb.SelectionStart = 0;
            this.KullanTb.ShortcutsEnabled = true;
            this.KullanTb.Size = new System.Drawing.Size(377, 48);
            this.KullanTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.KullanTb.TabIndex = 82;
            this.KullanTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KullanTb.TextMarginBottom = 0;
            this.KullanTb.TextMarginLeft = 3;
            this.KullanTb.TextMarginTop = 1;
            this.KullanTb.TextPlaceholder = "Kullanici adı";
            this.KullanTb.UseSystemPasswordChar = false;
            this.KullanTb.WordWrap = true;
            // 
            // Sifreetb
            // 
            this.Sifreetb.AcceptsReturn = false;
            this.Sifreetb.AcceptsTab = false;
            this.Sifreetb.AnimationSpeed = 200;
            this.Sifreetb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Sifreetb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Sifreetb.AutoSizeHeight = true;
            this.Sifreetb.BackColor = System.Drawing.Color.Transparent;
            this.Sifreetb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sifreetb.BackgroundImage")));
            this.Sifreetb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Sifreetb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Sifreetb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Sifreetb.BorderColorIdle = System.Drawing.Color.Silver;
            this.Sifreetb.BorderRadius = 30;
            this.Sifreetb.BorderThickness = 1;
            this.Sifreetb.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.Sifreetb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Sifreetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sifreetb.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Sifreetb.DefaultText = "";
            this.Sifreetb.FillColor = System.Drawing.Color.White;
            this.Sifreetb.ForeColor = System.Drawing.Color.Black;
            this.Sifreetb.HideSelection = true;
            this.Sifreetb.IconLeft = null;
            this.Sifreetb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Sifreetb.IconPadding = 10;
            this.Sifreetb.IconRight = null;
            this.Sifreetb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Sifreetb.Lines = new string[0];
            this.Sifreetb.Location = new System.Drawing.Point(379, 201);
            this.Sifreetb.MaxLength = 32767;
            this.Sifreetb.MinimumSize = new System.Drawing.Size(1, 1);
            this.Sifreetb.Modified = false;
            this.Sifreetb.Multiline = false;
            this.Sifreetb.Name = "Sifreetb";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Sifreetb.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Sifreetb.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Sifreetb.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Sifreetb.OnIdleState = stateProperties8;
            this.Sifreetb.Padding = new System.Windows.Forms.Padding(3);
            this.Sifreetb.PasswordChar = '*';
            this.Sifreetb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Sifreetb.PlaceholderText = "Konu girin.";
            this.Sifreetb.ReadOnly = false;
            this.Sifreetb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Sifreetb.SelectedText = "";
            this.Sifreetb.SelectionLength = 0;
            this.Sifreetb.SelectionStart = 0;
            this.Sifreetb.ShortcutsEnabled = true;
            this.Sifreetb.Size = new System.Drawing.Size(377, 46);
            this.Sifreetb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Sifreetb.TabIndex = 83;
            this.Sifreetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Sifreetb.TextMarginBottom = 0;
            this.Sifreetb.TextMarginLeft = 3;
            this.Sifreetb.TextMarginTop = 1;
            this.Sifreetb.TextPlaceholder = "Konu girin.";
            this.Sifreetb.UseSystemPasswordChar = false;
            this.Sifreetb.WordWrap = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.Sifreetb);
            this.Controls.Add(this.KullanTb);
            this.Controls.Add(this.DuyurularButton);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button GirisButton;
        private Guna.UI2.WinForms.Guna2Button DuyurularButton;
        private Bunifu.UI.WinForms.BunifuTextBox KullanTb;
        private Bunifu.UI.WinForms.BunifuTextBox Sifreetb;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

