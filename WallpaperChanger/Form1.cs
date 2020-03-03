using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WallpaperChanger;

namespace U4WC
{
    public partial class Form1 : MaterialForm
    {
        private readonly SystemRegistryService _registryService;
        private readonly MessageBoxService _msgBoxService;

        public Form1()
        {
            InitializeComponent();
            ApplyMaterialSkinSettings();
            SetFormDefault();

            _msgBoxService = new MessageBoxService();
            _registryService = new SystemRegistryService(_msgBoxService);
        }

        private void ApplyMaterialSkinSettings()
        {
            // Create a material theme manager and add the form to manage (this)
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen700,
                TextShade.WHITE
            );
        }

        private void SetFormDefault()
        {
            Sizable = false;


            regKeyName.Text = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System";
            regValueName.Text = @"Wallpaper";

            regValueData.Text = @"Click to select wallpaper...";

            regKeyName.Enabled = false;
            regValueName.Enabled = false;
            regValueData.Enabled = true;
            submitButton.Enabled = false;
        }

        private bool IsFormValid()
        {
            //todo Warning for each case or some separate validation mechanism 
            return !string.IsNullOrEmpty(regKeyName.Text) && 
                   !string.IsNullOrEmpty(regValueName.Text) &&
                   !string.IsNullOrEmpty(regValueData.Text) &&
                   File.Exists(regValueData.Text);
        }

        private void GetFileNameFromDialog()
        {
            //todo: move to file dialog service
            var codecs = ImageCodecInfo.GetImageEncoders();
            var filter = string.Format("Image files ({0}) | {1}",
                string.Join(", ", codecs.Select(c => c.FilenameExtension.ToLower())),
                string.Join("; ", codecs.Select(c => c.FilenameExtension)));

            openFileDialog1.Filter = filter;
            //openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                regValueData.Text = file;
            }
        }

        #region ClickEvents

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (termsCheckbox.Checked && IsFormValid())
            {
                _registryService.UpdateRegistryKey(regKeyName.Text, regValueName.Text, regValueData.Text);
            }
            else
            {
                _msgBoxService.Warning(@"Form is not valid!");
            }
        }

        private void openRegEdit_Click(object sender, EventArgs e)
        {
            _registryService.OpenRegistryEditor();
        }

        private void regValueData_Click(object sender, EventArgs e)
        {
            GetFileNameFromDialog();
        }

        private void termsCheckbox_Click(object sender, EventArgs e)
        {
            var checkbox = (CheckBox) sender;
            submitButton.Enabled = checkbox.Checked;
        }
        #endregion
    }
}