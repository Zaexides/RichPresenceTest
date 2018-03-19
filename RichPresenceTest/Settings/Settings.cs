using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

using static System.Text.Encoding;

namespace RichPresenceTest
{
    public class Settings
    {
        [JsonIgnore]
        private static Settings singleton;

        [JsonIgnore]
        private static JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.Auto
        };

        private const string SETTINGS_FILE = "/settings.user";

        [JsonProperty] private List<Application> applications = new List<Application>();
        [JsonProperty] private int lastSelectedApplication = -1;
        [JsonProperty] private bool updateOnStartup = false;
        [JsonProperty] private bool saveTimestamp = false;
        [JsonProperty] private bool saveDifference = false;

        [JsonIgnore]
        public static Settings Main
        {
            get
            {
                if (singleton == null)
                    singleton = new Settings();
                return singleton;
            }
        }

        [JsonIgnore]
        public int LastSelectedApplication
        {
            get => lastSelectedApplication;
            set
            {
                lastSelectedApplication = value;
                Save();
            }
        }

        [JsonIgnore]
        public bool UpdateOnStartup
        {
            get => updateOnStartup;
            set
            {
                updateOnStartup = value;
                Save();
            }
        }

        [JsonIgnore]
        public bool SaveTimestamp
        {
            get => saveTimestamp;
            set
            {
                saveTimestamp = value;
                Save();
            }
        }

        [JsonIgnore]
        public bool SaveDifference
        {
            get => saveDifference;
            set
            {
                saveDifference = value;
                Save();
            }
        }

        [JsonIgnore]
        public int ApplicationCount => applications.Count;

        public Application GetApplication(int index) => applications[index];

        public void RemoveApplication(int index)
        {
            applications.RemoveAt(index);
            Save();
        }

        public void RenameApplication(string appId, string newName)
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

        public void AddApplication(Application application)
        {
            applications.Add(application);
            Save();
        }

        public Application[] GetApplicationArray() => applications.ToArray();

        public bool ContainsApplicationWithName(string name)
        {
            foreach(Application app in applications)
            {
                if (app.name.Equals(name))
                    return true;
            }
            return false;
        }

        public bool ContainsApplicationWithID(string id)
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
            string json = JsonConvert.SerializeObject(singleton, jsonSerializerSettings);

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
            singleton = JsonConvert.DeserializeObject<Settings>(json, jsonSerializerSettings);
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

            [JsonProperty] private bool useTime;
            [JsonProperty] private bool isEndTime;

            [JsonProperty] private bool useParty;
            [JsonProperty] private int partySize = 1, partyMax = 1;

            [JsonProperty] private ITimeSetting timeSetting;

            [JsonIgnore]
            public ITimeSetting TimeSetting
            {
                get => timeSetting;
                set
                {
                    timeSetting = value;
                    Settings.Save();
                }
            }

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

            [JsonIgnore]
            public bool UseTime
            {
                get => useTime;
                set
                {
                    useTime = value;
                    Settings.Save();
                }
            }

            [JsonIgnore]
            public bool UseEndTime
            {
                get => isEndTime;
                set
                {
                    isEndTime = value;
                    Settings.Save();
                }
            }

            [JsonIgnore]
            public bool UseParty
            {
                get => useParty;
                set
                {
                    useParty = value;
                    Settings.Save();
                }
            }

            public int PartySize { get => partySize; set => SetParty(value, PartyMax); }
            public int PartyMax { get => partyMax; set => SetParty(PartySize, value); }

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

            public void SetParty(int size, int max)
            {
                this.partySize = size;
                this.partyMax = max;
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
