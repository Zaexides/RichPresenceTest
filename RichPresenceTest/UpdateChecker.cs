﻿using System;
using System.Net;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

public static class UpdateChecker
{
    public const string CURRENT_VERSION = "v1.2.0";
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

            ulong newVersion = GetVersionNumberFromVersionString(buildUpdates.stable);
            ulong oldVersion = GetVersionNumberFromVersionString(CURRENT_VERSION);
            
            return oldVersion >= newVersion;
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
        try
        {
            WebRequest webRequest = WebRequest.Create(UPDATE_URL);
            WebResponse webResponse = webRequest.GetResponse();
            Stream webStream = webResponse.GetResponseStream();
            string json = string.Empty;
            using (StreamReader reader = new StreamReader(webStream))
                json = reader.ReadToEnd();

            updateData = JsonConvert.DeserializeObject<UpdateData>(json);
        }
        catch
        {
            //Well that sucks.
        }
    }

    private static ulong GetVersionNumberFromVersionString(string version)
    {
        string[] splitVersion = version.Split('.');
        ulong versionNumber = 0;

        for (int i = splitVersion.Length - 1, p = 0; i >= 0; i--, p += 10)
        {
            ulong numeric = ulong.Parse(new string(splitVersion[i].Where(c => char.IsDigit(c)).ToArray()));
            versionNumber += numeric << p;
        }
        return versionNumber;
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