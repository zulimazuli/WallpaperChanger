using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WallpaperChanger
{
    public class SystemRegistryService
    {
        private const string RegEditExe = "regedit.exe";

        private readonly MessageBoxService _msgBoxService;

        //For future reference in IoC
        public SystemRegistryService(MessageBoxService msgBoxService)
        {
            _msgBoxService = msgBoxService;
        }

        public SystemRegistryService()
        {
            _msgBoxService = new MessageBoxService();;
        }

        public void UpdateRegistryKey(string keyName, string valueName, string valueData)
        {
            var keyValue = Registry.GetValue(keyName, valueName, null);
            if (keyValue != null)
            {
                Registry.SetValue(keyName, valueName, valueData);
            }
            else
            {
                _msgBoxService.Warning(@"The key or value does not exist in the registry.");
            }
        }

        public void OpenRegistryEditor()
        {
            try
            {
                Process.Start(RegEditExe);
            }
            catch (Exception e)
            {
               _msgBoxService.Error(e.Message);
            }
            
        }
    }
}
