using IWshRuntimeLibrary;
using System;
using System.Windows.Forms;

public static class ShortcutProvider
{
    private static readonly string shortcutPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Startup)}/RichPresenceTester.lnk";

    public static void CreateShortcut()
    {
        WshShell shell = new WshShell();
        IWshShortcut shortcut = shell.CreateShortcut(shortcutPath);
        shortcut.WorkingDirectory = Application.StartupPath;
        shortcut.TargetPath = Application.ExecutablePath;
        shortcut.Description = "Rich Presence Tester shortcut (auto-generated)";
        shortcut.Arguments = "-auto";
        shortcut.Save();
    }

    public static void DeleteShortcut()
    {
        if (System.IO.File.Exists(shortcutPath))
            System.IO.File.Delete(shortcutPath);
    }

    public static bool ShortcutExists() => System.IO.File.Exists(shortcutPath);
}