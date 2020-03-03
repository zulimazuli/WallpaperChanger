using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperChanger
{
    public class MessageBoxService
    {
        public void Show(string message, string title = null)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        public void Error(string errorMessage)
        {
            var msg = "Error occured:\n " + errorMessage;
            MessageBox.Show(msg, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warning(string warningMessage)
        {
            MessageBox.Show(warningMessage, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
