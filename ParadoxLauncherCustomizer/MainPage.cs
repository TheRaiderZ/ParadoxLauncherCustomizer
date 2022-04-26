using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace ParadoxLauncherCustomizer
{
    public partial class MainPage : MaterialForm
    {
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        
        private string logoFile, buttonFile, backgroundFile, fontFile, folderName;

        private bool fileOpened = false;
        private List<string> files=new List<string>();
        LauncherSettings launcherSettings;
        public MainPage()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private void MainPage_Load(object sender, EventArgs e)
        {
            pdxFolderBrowser.ShowNewFolderButton = false;

            

            if (materialSkinManager.Theme==MaterialSkinManager.Themes.LIGHT)
            {
                themeSwitch.Checked = false;
            }
            else
            {
                themeSwitch.Checked=true;
            }

        }

        private void themeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (themeSwitch.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red100, TextShade.WHITE);
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            }
        }

        private void tab_settings_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnOpenLocation_Click(object sender, EventArgs e)
        {
            
            DialogResult result = pdxFolderBrowser.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(pdxFolderBrowser.SelectedPath) && Path.GetFileName(pdxFolderBrowser.SelectedPath)=="launcher-assets")
            {
                folderName = pdxFolderBrowser.SelectedPath;
                txtLocation.Text = folderName;
                files= Directory.GetFiles(folderName).ToList();
                string jsonSettings = "theme-settings.json";
                string jsonDefault = Path.Combine(folderName, "theme-settings-default.json");
                if (files.Any(x=> Path.GetFileName(x)==jsonSettings))
                {
                    string pathJson = files.Find(x => Path.GetFileName(x) == jsonSettings);
                    if (!File.Exists(jsonDefault))
                        File.Copy(pathJson, jsonDefault);
                    launcherSettings = JsonConvert.DeserializeObject<LauncherSettings>(File.ReadAllText(pathJson));
                }

                if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    //openFileDialog1.InitialDirectory = folderName;
                    //openFileDialog1.FileName = null;
                    //openMenuItem.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Folder is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (launcherSettings!=null)
            {
                if (File.Exists(logoFile))
                {
                    String fileName = Path.GetFileName(logoFile);
                    File.Copy(logoFile, Path.Combine(folderName, fileName),true);
                    launcherSettings.Logo.ImagePath = fileName;
                }
                if (File.Exists(backgroundFile))
                {
                    String fileName = Path.GetFileName(backgroundFile);
                    File.Copy(backgroundFile, Path.Combine(folderName, fileName), true);
                    launcherSettings.Background.BackgroundImage = fileName;
                }
                if (File.Exists(buttonFile))
                {
                    String fileName = Path.GetFileName(buttonFile);
                    File.Copy(buttonFile, Path.Combine(folderName, fileName), true);
                    launcherSettings.Button.BackgroundImage = fileName;
                }
                if (File.Exists(fontFile))
                {
                    String fileName = Path.GetFileName(fontFile);
                    File.Copy(fontFile, Path.Combine(folderName, fileName), true);
                    launcherSettings.Button.FontPath = fileName;
                }
                File.WriteAllText(Path.Combine(folderName, "theme-settings.json"), JsonConvert.SerializeObject(launcherSettings, Formatting.Indented));
                
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (launcherSettings != null)
            {
                File.WriteAllText(Path.Combine(folderName, "theme-settings.json"), File.ReadAllText(Path.Combine(folderName, "theme-settings-default.json")));

            }
        }

        private void btnBackLoc_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                backgroundFile = openFileDialog.FileName;
                txtBackLoc.Text = backgroundFile;
            }
        }

        private void btnButtonLoc_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                buttonFile = openFileDialog.FileName;
                txtBtnLoc.Text = buttonFile;
            }
        }

        private void btnFontLoc_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Font Files|*.ttf";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                fontFile = openFileDialog.FileName;
                txtFontLoc.Text = fontFile;
            }
        }

        private void btnLogoLoc_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                logoFile = openFileDialog.FileName;
                txtLogoLoc.Text = logoFile;
            }
        }
    }
}
