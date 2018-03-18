# RichPresenceTester
A simple C# application for testing Discord Rich Presence.  

# Getting Started
First of all, go to the Discord Developer page and create an application, then enable rich presence on it and add whatever you want. In the tester, put the "Client ID" in the "App ID" field and give it a name you'll recognize it with, then press the "Add" button. It should now appear in the dropdown on the left.  

To add icons, enter the icon name and whether it's a small or large icon, then press add.  

To change the in-app name, simply paste in the same Client ID and give it a different name. The "Add" button should turn into a "Rename" button.

# Requirements
- A windows computer (OS should be windows 7 SP1 or higher)
- .NET Framework 4.6.1 redistributable (https://www.microsoft.com/en-us/download/details.aspx?id=49982)
- Discord

# Troubleshooting
- If you get an error, post it to the issue tracker.
- If nothing happens after pressing the update button, wait a couple of seconds. Updating the rich presence status can take up to 20 seconds.
- If after 20 seconds nothing happens, download the discord-rpc libraries from https://github.com/discordapp/discord-rpc/releases and replace the old ones, then post the results to the issue tracker so I can update the included libraries.
