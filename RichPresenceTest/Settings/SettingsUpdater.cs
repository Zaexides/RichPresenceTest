using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPresenceTest.Setting
{
    public static class SettingsUpdater
    {
        public static void UpdateSettings(ulong versionId)
        {
            if (versionId <= 0)
                UpdateFrom_1_2_1(Settings.Main);
        }

        private static void UpdateFrom_1_2_1(Settings settings)
        {
            foreach(Settings.Application app in settings.applications)
            {
                app.TimeSetting.DateTime = app.TimeSetting.DateTime.AddHours(1);
            }
        }
    }
}
