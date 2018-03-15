using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

public static class UpdateChecker
{
    public const string CURRENT_VERSION = "v1.1.0";
    public const string DOWNLOAD_URL = @"https://github.com/Zaexides/RichPresenceTest/releases";

    private const string UPDATE_URL = "https://gist.githubusercontent.com/Zaexides/22349c662f199f3605cb6f86541de12e/raw/ce809993a8480098823e112c64d7ba86d7b6bebe/RichPresenceTest%2520Update%2520JSON";

    public static UpdateData updateData;

    public static bool IsUpToDate
    {
        get
        {
            UpdateData.BuildUpdates buildUpdates;
#if x64
            buildUpdates = updateData.x64;
#elif x86
            buildUpdates = updateData.x86;
#endif
            return buildUpdates.stable.Equals(CURRENT_VERSION);
        }
    }

    public static string LatestVersion
    {
#if x64
        get => updateData.x64.latest;
#elif x86
        get => updateData.x86.latest;
#endif
    }

    public static string LatestStableVersion
    {
#if x64
        get => updateData.x64.stable;
#elif x86
        get => updateData.x86.stable;
#endif
    }

    public static void CheckForUpdates()
    {
        WebRequest webRequest = WebRequest.Create(UPDATE_URL);
        WebResponse webResponse = webRequest.GetResponse();
        Stream webStream = webResponse.GetResponseStream();
        string json = string.Empty;
        using (StreamReader reader = new StreamReader(webStream))
            json = reader.ReadToEnd();

        updateData = JsonConvert.DeserializeObject<UpdateData>(json);
    }


    public class UpdateData
    {
        public BuildUpdates x64, x86;

        public class BuildUpdates
        {
            public string stable;
            public string latest;
        }
    }
}