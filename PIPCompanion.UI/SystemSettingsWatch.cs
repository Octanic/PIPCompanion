using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Principal;
using System.Text;

namespace PIPCompanion.UI
{
    public class SystemSettingsWatch
    {
        private const string REG_KEY_PATH = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const string REG_VALUE = "AppsUseLightTheme";

        private enum WindowsTheme
        {
            Light,
            Dark
        }


		public void WatchTheme()
		{
			var currentUser = WindowsIdentity.GetCurrent();
			string query = string.Format(
				CultureInfo.InvariantCulture,
				@"SELECT * FROM RegistryValueChangeEvent WHERE Hive = 'HKEY_USERS' AND KeyPath = '{0}\\{1}' AND ValueName = '{2}'",
				currentUser.User.Value,
				REG_KEY_PATH.Replace(@"\", @"\\"),
				REG_VALUE);

			try
			{
				var watcher = new ManagementEventWatcher(query);
				watcher.EventArrived += (sender, args) =>
				{
					WindowsTheme newWindowsTheme = getWindowsTheme();
					// React to new theme
				};

				// Start listening for events
				watcher.Start();
			}
			catch (Exception)
			{
				// This can fail on Windows 7
			}

			WindowsTheme initialTheme = getWindowsTheme();
		}

		private static WindowsTheme getWindowsTheme()
		{
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(REG_KEY_PATH))
			{
				object registryValueObject = key?.GetValue(REG_VALUE);
				if (registryValueObject == null)
				{
					return WindowsTheme.Light;
				}

				int registryValue = (int)registryValueObject;

				return registryValue > 0 ? WindowsTheme.Light : WindowsTheme.Dark;
			}
		}
	}
}
