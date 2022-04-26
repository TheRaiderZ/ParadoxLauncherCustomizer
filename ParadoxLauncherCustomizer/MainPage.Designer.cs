namespace ParadoxLauncherCustomizer
{
    partial class MainPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.btnDefault = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnLogoLoc = new MaterialSkin.Controls.MaterialButton();
            this.txtLogoLoc = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnFontLoc = new MaterialSkin.Controls.MaterialButton();
            this.txtFontLoc = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnButtonLoc = new MaterialSkin.Controls.MaterialButton();
            this.txtBtnLoc = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBackLoc = new MaterialSkin.Controls.MaterialButton();
            this.txtBackLoc = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnOpenLocation = new MaterialSkin.Controls.MaterialButton();
            this.txtLocation = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.themeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pdxFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_main);
            this.tabControl.Controls.Add(this.tab_settings);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(0, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(847, 383);
            this.tabControl.TabIndex = 0;
            // 
            // tab_main
            // 
            this.tab_main.BackColor = System.Drawing.SystemColors.Control;
            this.tab_main.Controls.Add(this.btnDefault);
            this.tab_main.Controls.Add(this.btnSave);
            this.tab_main.Controls.Add(this.btnLogoLoc);
            this.tab_main.Controls.Add(this.txtLogoLoc);
            this.tab_main.Controls.Add(this.btnFontLoc);
            this.tab_main.Controls.Add(this.txtFontLoc);
            this.tab_main.Controls.Add(this.btnButtonLoc);
            this.tab_main.Controls.Add(this.txtBtnLoc);
            this.tab_main.Controls.Add(this.btnBackLoc);
            this.tab_main.Controls.Add(this.txtBackLoc);
            this.tab_main.Controls.Add(this.btnOpenLocation);
            this.tab_main.Controls.Add(this.txtLocation);
            this.tab_main.Controls.Add(this.materialDivider1);
            this.tab_main.ImageKey = "icons8-home-50.png";
            this.tab_main.Location = new System.Drawing.Point(4, 31);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(839, 348);
            this.tab_main.TabIndex = 0;
            this.tab_main.Text = "Main Page";
            // 
            // btnDefault
            // 
            this.btnDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDefault.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDefault.Depth = 0;
            this.btnDefault.HighEmphasis = true;
            this.btnDefault.Icon = ((System.Drawing.Image)(resources.GetObject("btnDefault.Icon")));
            this.btnDefault.Location = new System.Drawing.Point(667, 286);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDefault.Size = new System.Drawing.Size(112, 36);
            this.btnDefault.TabIndex = 13;
            this.btnDefault.Text = "Default";
            this.btnDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDefault.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDefault.UseAccentColor = true;
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(561, 286);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogoLoc
            // 
            this.btnLogoLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogoLoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogoLoc.Depth = 0;
            this.btnLogoLoc.HighEmphasis = true;
            this.btnLogoLoc.Icon = ((System.Drawing.Image)(resources.GetObject("btnLogoLoc.Icon")));
            this.btnLogoLoc.Location = new System.Drawing.Point(413, 264);
            this.btnLogoLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogoLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogoLoc.Name = "btnLogoLoc";
            this.btnLogoLoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogoLoc.Size = new System.Drawing.Size(88, 36);
            this.btnLogoLoc.TabIndex = 11;
            this.btnLogoLoc.Text = "Open";
            this.btnLogoLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogoLoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogoLoc.UseAccentColor = false;
            this.btnLogoLoc.UseVisualStyleBackColor = true;
            this.btnLogoLoc.Click += new System.EventHandler(this.btnLogoLoc_Click);
            // 
            // txtLogoLoc
            // 
            this.txtLogoLoc.AnimateReadOnly = false;
            this.txtLogoLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLogoLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLogoLoc.Depth = 0;
            this.txtLogoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogoLoc.HideSelection = true;
            this.txtLogoLoc.Hint = "Logo image";
            this.txtLogoLoc.LeadingIcon = null;
            this.txtLogoLoc.Location = new System.Drawing.Point(156, 258);
            this.txtLogoLoc.MaxLength = 32767;
            this.txtLogoLoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogoLoc.Name = "txtLogoLoc";
            this.txtLogoLoc.PasswordChar = '\0';
            this.txtLogoLoc.PrefixSuffixText = null;
            this.txtLogoLoc.ReadOnly = true;
            this.txtLogoLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogoLoc.SelectedText = "";
            this.txtLogoLoc.SelectionLength = 0;
            this.txtLogoLoc.SelectionStart = 0;
            this.txtLogoLoc.ShortcutsEnabled = true;
            this.txtLogoLoc.Size = new System.Drawing.Size(250, 48);
            this.txtLogoLoc.TabIndex = 10;
            this.txtLogoLoc.TabStop = false;
            this.txtLogoLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogoLoc.TrailingIcon = null;
            this.txtLogoLoc.UseSystemPasswordChar = false;
            // 
            // btnFontLoc
            // 
            this.btnFontLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFontLoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFontLoc.Depth = 0;
            this.btnFontLoc.HighEmphasis = true;
            this.btnFontLoc.Icon = ((System.Drawing.Image)(resources.GetObject("btnFontLoc.Icon")));
            this.btnFontLoc.Location = new System.Drawing.Point(413, 210);
            this.btnFontLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFontLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFontLoc.Name = "btnFontLoc";
            this.btnFontLoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFontLoc.Size = new System.Drawing.Size(88, 36);
            this.btnFontLoc.TabIndex = 9;
            this.btnFontLoc.Text = "Open";
            this.btnFontLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFontLoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFontLoc.UseAccentColor = false;
            this.btnFontLoc.UseVisualStyleBackColor = true;
            this.btnFontLoc.Click += new System.EventHandler(this.btnFontLoc_Click);
            // 
            // txtFontLoc
            // 
            this.txtFontLoc.AnimateReadOnly = false;
            this.txtFontLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFontLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFontLoc.Depth = 0;
            this.txtFontLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFontLoc.HideSelection = true;
            this.txtFontLoc.Hint = "Launcher font";
            this.txtFontLoc.LeadingIcon = null;
            this.txtFontLoc.Location = new System.Drawing.Point(156, 204);
            this.txtFontLoc.MaxLength = 32767;
            this.txtFontLoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFontLoc.Name = "txtFontLoc";
            this.txtFontLoc.PasswordChar = '\0';
            this.txtFontLoc.PrefixSuffixText = null;
            this.txtFontLoc.ReadOnly = true;
            this.txtFontLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFontLoc.SelectedText = "";
            this.txtFontLoc.SelectionLength = 0;
            this.txtFontLoc.SelectionStart = 0;
            this.txtFontLoc.ShortcutsEnabled = true;
            this.txtFontLoc.Size = new System.Drawing.Size(250, 48);
            this.txtFontLoc.TabIndex = 8;
            this.txtFontLoc.TabStop = false;
            this.txtFontLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFontLoc.TrailingIcon = null;
            this.txtFontLoc.UseSystemPasswordChar = false;
            // 
            // btnButtonLoc
            // 
            this.btnButtonLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnButtonLoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnButtonLoc.Depth = 0;
            this.btnButtonLoc.HighEmphasis = true;
            this.btnButtonLoc.Icon = ((System.Drawing.Image)(resources.GetObject("btnButtonLoc.Icon")));
            this.btnButtonLoc.Location = new System.Drawing.Point(413, 156);
            this.btnButtonLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnButtonLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnButtonLoc.Name = "btnButtonLoc";
            this.btnButtonLoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnButtonLoc.Size = new System.Drawing.Size(88, 36);
            this.btnButtonLoc.TabIndex = 7;
            this.btnButtonLoc.Text = "Open";
            this.btnButtonLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnButtonLoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnButtonLoc.UseAccentColor = false;
            this.btnButtonLoc.UseVisualStyleBackColor = true;
            this.btnButtonLoc.Click += new System.EventHandler(this.btnButtonLoc_Click);
            // 
            // txtBtnLoc
            // 
            this.txtBtnLoc.AnimateReadOnly = false;
            this.txtBtnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBtnLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBtnLoc.Depth = 0;
            this.txtBtnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBtnLoc.HideSelection = true;
            this.txtBtnLoc.Hint = "Button image";
            this.txtBtnLoc.LeadingIcon = null;
            this.txtBtnLoc.Location = new System.Drawing.Point(156, 150);
            this.txtBtnLoc.MaxLength = 32767;
            this.txtBtnLoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBtnLoc.Name = "txtBtnLoc";
            this.txtBtnLoc.PasswordChar = '\0';
            this.txtBtnLoc.PrefixSuffixText = null;
            this.txtBtnLoc.ReadOnly = true;
            this.txtBtnLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBtnLoc.SelectedText = "";
            this.txtBtnLoc.SelectionLength = 0;
            this.txtBtnLoc.SelectionStart = 0;
            this.txtBtnLoc.ShortcutsEnabled = true;
            this.txtBtnLoc.Size = new System.Drawing.Size(250, 48);
            this.txtBtnLoc.TabIndex = 6;
            this.txtBtnLoc.TabStop = false;
            this.txtBtnLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBtnLoc.TrailingIcon = null;
            this.txtBtnLoc.UseSystemPasswordChar = false;
            // 
            // btnBackLoc
            // 
            this.btnBackLoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackLoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBackLoc.Depth = 0;
            this.btnBackLoc.HighEmphasis = true;
            this.btnBackLoc.Icon = ((System.Drawing.Image)(resources.GetObject("btnBackLoc.Icon")));
            this.btnBackLoc.Location = new System.Drawing.Point(413, 102);
            this.btnBackLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackLoc.Name = "btnBackLoc";
            this.btnBackLoc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBackLoc.Size = new System.Drawing.Size(88, 36);
            this.btnBackLoc.TabIndex = 5;
            this.btnBackLoc.Text = "Open";
            this.btnBackLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackLoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBackLoc.UseAccentColor = false;
            this.btnBackLoc.UseVisualStyleBackColor = true;
            this.btnBackLoc.Click += new System.EventHandler(this.btnBackLoc_Click);
            // 
            // txtBackLoc
            // 
            this.txtBackLoc.AnimateReadOnly = false;
            this.txtBackLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBackLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBackLoc.Depth = 0;
            this.txtBackLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBackLoc.HideSelection = true;
            this.txtBackLoc.Hint = "Background image";
            this.txtBackLoc.LeadingIcon = null;
            this.txtBackLoc.Location = new System.Drawing.Point(156, 96);
            this.txtBackLoc.MaxLength = 32767;
            this.txtBackLoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBackLoc.Name = "txtBackLoc";
            this.txtBackLoc.PasswordChar = '\0';
            this.txtBackLoc.PrefixSuffixText = null;
            this.txtBackLoc.ReadOnly = true;
            this.txtBackLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackLoc.SelectedText = "";
            this.txtBackLoc.SelectionLength = 0;
            this.txtBackLoc.SelectionStart = 0;
            this.txtBackLoc.ShortcutsEnabled = true;
            this.txtBackLoc.Size = new System.Drawing.Size(250, 48);
            this.txtBackLoc.TabIndex = 4;
            this.txtBackLoc.TabStop = false;
            this.txtBackLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBackLoc.TrailingIcon = null;
            this.txtBackLoc.UseSystemPasswordChar = false;
            // 
            // btnOpenLocation
            // 
            this.btnOpenLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenLocation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenLocation.Depth = 0;
            this.btnOpenLocation.HighEmphasis = true;
            this.btnOpenLocation.Icon = ((System.Drawing.Image)(resources.GetObject("btnOpenLocation.Icon")));
            this.btnOpenLocation.Location = new System.Drawing.Point(413, 48);
            this.btnOpenLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenLocation.Name = "btnOpenLocation";
            this.btnOpenLocation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenLocation.Size = new System.Drawing.Size(88, 36);
            this.btnOpenLocation.TabIndex = 3;
            this.btnOpenLocation.Text = "Open";
            this.btnOpenLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenLocation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenLocation.UseAccentColor = false;
            this.btnOpenLocation.UseVisualStyleBackColor = true;
            this.btnOpenLocation.Click += new System.EventHandler(this.btnOpenLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.AnimateReadOnly = false;
            this.txtLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLocation.Depth = 0;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocation.HideSelection = true;
            this.txtLocation.Hint = "Launcher assets location";
            this.txtLocation.LeadingIcon = null;
            this.txtLocation.Location = new System.Drawing.Point(156, 42);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PrefixSuffixText = null;
            this.txtLocation.ReadOnly = true;
            this.txtLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.Size = new System.Drawing.Size(250, 48);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.TabStop = false;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLocation.TrailingIcon = null;
            this.txtLocation.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(136, 23);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(405, 299);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "Test";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // tab_settings
            // 
            this.tab_settings.BackColor = System.Drawing.SystemColors.Control;
            this.tab_settings.Controls.Add(this.materialLabel1);
            this.tab_settings.Controls.Add(this.materialCard2);
            this.tab_settings.ImageKey = "icons8-settings-50.png";
            this.tab_settings.Location = new System.Drawing.Point(4, 31);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(786, 348);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.Click += new System.EventHandler(this.tab_settings_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(257, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Change Theme";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Controls.Add(this.themeSwitch);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(257, 53);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(280, 103);
            this.materialCard2.TabIndex = 1;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // themeSwitch
            // 
            this.themeSwitch.AutoSize = true;
            this.themeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.themeSwitch.Depth = 0;
            this.themeSwitch.Location = new System.Drawing.Point(68, 33);
            this.themeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.themeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeSwitch.Name = "themeSwitch";
            this.themeSwitch.Ripple = true;
            this.themeSwitch.Size = new System.Drawing.Size(144, 37);
            this.themeSwitch.TabIndex = 0;
            this.themeSwitch.Text = "Dark Theme";
            this.themeSwitch.UseVisualStyleBackColor = false;
            this.themeSwitch.CheckedChanged += new System.EventHandler(this.themeSwitch_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-settings-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-ok.gif");
            this.imageList1.Images.SetKeyName(3, "icons8-ok-48.png");
            // 
            // pdxFolderBrowser
            // 
            this.pdxFolderBrowser.ShowNewFolderButton = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif\"";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Text = "Paradox Launcher Customizer";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tab_main.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSwitch themeSwitch;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.FolderBrowserDialog pdxFolderBrowser;
        private MaterialSkin.Controls.MaterialTextBox2 txtLocation;
        private MaterialSkin.Controls.MaterialButton btnOpenLocation;
        private MaterialSkin.Controls.MaterialButton btnLogoLoc;
        private MaterialSkin.Controls.MaterialTextBox2 txtLogoLoc;
        private MaterialSkin.Controls.MaterialButton btnFontLoc;
        private MaterialSkin.Controls.MaterialTextBox2 txtFontLoc;
        private MaterialSkin.Controls.MaterialButton btnButtonLoc;
        private MaterialSkin.Controls.MaterialTextBox2 txtBtnLoc;
        private MaterialSkin.Controls.MaterialButton btnBackLoc;
        private MaterialSkin.Controls.MaterialTextBox2 txtBackLoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialButton btnDefault;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}

