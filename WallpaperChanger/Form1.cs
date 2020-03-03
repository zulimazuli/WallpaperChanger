using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace U4WC
{
    public partial class Form1 : MaterialForm
    {
        private readonly RegistryEditorService _regservice;
        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE
            );


            SetDefault();
            _regservice = new RegistryEditorService();
        }


        private void SetDefault()
        {
            regKeyName.Text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            regValueName.Text = "Wallpaper";
            regValueData.Text = "%ProgramData%\\Unit4\\Unit4_DesktopImage.jpg";

            regKeyName.Enabled = false;
            regValueName.Enabled = false;
            regValueData.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(regKeyName.Text) && !string.IsNullOrEmpty(regValueName.Text) && !string.IsNullOrEmpty(regValueData.Text))
            {
                _regservice.WriteRegistryKey(regKeyName.Text, regValueName.Text, regValueData.Text);
            }                
        }

        private void openRegEdit_Click(object sender, EventArgs e)
        {
            _regservice.OpenRegistryEditor();
        }

        private void regValueData_Click(object sender, EventArgs e)
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            var filter = string.Format("Image files ({0}) | {1}", 
                string.Join(", ", codecs.Select(c => c.FilenameExtension.ToLower())),
                string.Join("; ", codecs.Select(c => c.FilenameExtension)));
            openFileDialog1.Filter = filter;

            //openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif";
            DialogResult result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                regValueData.Text = file;                
            }
        }
    }
}
