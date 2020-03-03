using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4WC
{
    public class RegistryEditorService
    {
        //%ProgramData%\Unit4\Unit4_DesktopImage.jpg
        public void WriteRegistryKey(string keyName, string valueName, string valueData)
        {
            Registry.SetValue(keyName, valueName, valueData);
        }

        public void OpenRegistryEditor()
        {            
            Process.Start("regedit.exe");
        }
    }
}
