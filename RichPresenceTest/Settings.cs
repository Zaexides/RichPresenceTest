using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

using static System.Text.Encoding;

namespace RichPresenceTest
{
    public static class Settings
    {
        private const string SETTINGS_FILE = "/settings.user";

        private static List<Application> applications = new List<Application>();

        public static int ApplicationCount => applications.Count;

        public static Application GetApplication(int index) => applications[index];

        public static void RemoveApplication(int index)
        {
            applications.RemoveAt(index);
            Save();
        }

        public static void RenameApplication(string appId, string newName)
        {
            foreach(Application app in applications)
            {
                if(app.appId.Equals(appId))
                {
                    app.name = newName;
                    return;
                }
            }
        }

        public static void AddApplication(Application application)
        {
            applications.Add(application);
            Save();
        }

        public static Application[] GetApplicationArray() => applications.ToArray();

        public static bool ContainsApplicationWithName(string name)
        {
            foreach(Application app in applications)
            {
                if (app.name.Equals(name))
                    return true;
            }
            return false;
        }

        public static bool ContainsApplicationWithID(string id)
        {
            foreach(Application app in applications)
            {
                if (app.appId.Equals(id))
                    return true;
            }
            return false;
        }

        private static void Save()
        {
            string json = JsonConvert.SerializeObject(applications);

            byte[] jsonBytes = UTF8.GetBytes(json);
            byte o = 0;
            for(int i = 0; i < jsonBytes.Length; i++, o++)
            {
                if (o >= 8)
                    o = 0;
                jsonBytes[i] = (byte)(jsonBytes[i] << o | jsonBytes[i] >> (8 - o));
            }
            string b64 = System.Convert.ToBase64String(jsonBytes);
            File.WriteAllText(Environment.CurrentDirectory + SETTINGS_FILE, b64);
        }

        public static void Load()
        {
            if (!File.Exists(Environment.CurrentDirectory + SETTINGS_FILE))
                return;
            string b64 = File.ReadAllText(Environment.CurrentDirectory + SETTINGS_FILE);
            byte[] jsonBytes = System.Convert.FromBase64String(b64);
            byte o = 0;
            for(int i = 0; i < jsonBytes.Length; i++, o++)
            {
                if (o >= 8)
                    o = 0;
                jsonBytes[i] = (byte)(jsonBytes[i] << (8 - o) | jsonBytes[i] >> o);
            }
            string json = UTF8.GetString(jsonBytes);
            applications = JsonConvert.DeserializeObject<List<Application>>(json);
        }

        public class Application
        {
            public string name;
            public readonly string appId;
            [JsonProperty] private List<string> smallIcons = new List<string>() { "none" };
            [JsonProperty] private List<string> largeIcons = new List<string>() { "none" };
            [JsonProperty] private List<string> smallIconText = new List<string>() { "none" };
            [JsonProperty] private List<string> largeIconText = new List<string>() { "none" };

            [JsonProperty] private string detailsText;
            [JsonProperty] private string stateText;

            [JsonProperty] private int smallIconIndex;
            [JsonProperty] private int largeIconIndex;

            [JsonIgnore]
            public string DetailsText
            {
                get => detailsText;
                set
                {
                    detailsText = value;
                    Settings.Save();
                }
            }

            [JsonIgnore]
            public string StateText
            {
                get => stateText;
                set
                {
                    stateText = value;
                    Settings.Save();
                }
            }

            [JsonIgnore]
            public int SmallIconIndex
            {
                get => smallIconIndex;
                set
                {
                    smallIconIndex = value;
                    Settings.Save();
                }
            }

            [JsonIgnore]
            public int LargeIconIndex
            {
                get => largeIconIndex;
                set
                {
                    largeIconIndex = value;
                    Settings.Save();
                }
            }

            public Application(string name, string appId)
            {
                this.name = name;
                this.appId = appId;
            }

            public void AddSmallIcon(string name)
            {
                smallIcons.Add(name);
                smallIconText.Add(string.Empty);
                Settings.Save();
            }

            public void RemoveSmallIcon(int index)
            {
                if (index == 0)
                    return;
                smallIcons.RemoveAt(index);
                smallIconText.RemoveAt(index);
                Settings.Save();
            }

            public void AddLargeIcon(string name)
            {
                largeIcons.Add(name);
                largeIconText.Add(string.Empty);
                Settings.Save();
            }

            public void RemoveLargeIcon(int index)
            {
                if (index == 0)
                    return;
                largeIcons.RemoveAt(index);
                largeIconText.RemoveAt(index);
                Settings.Save();
            }

            public void SetSmallIconText(int index, string text)
            {
                smallIconText[index] = text;
                Settings.Save();
            }

            public void SetLargeIconText(int index, string text)
            {
                largeIconText[index] = text;
                Settings.Save();
            }

            public string GetSmallIconText(int index) => smallIconText[index];
            public string GetLargeIconText(int index) => largeIconText[index];

            public string[] SmallIconArray => smallIcons.ToArray();
            public string[] LargeIconArray => largeIcons.ToArray();

            public bool ContainsIconName(string name)
            {
                return smallIcons.Contains(name) || largeIcons.Contains(name);
            }

            public override string ToString()
            {
                return $"{name} ({appId})";
            }
        }
    }
}
