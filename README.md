# Jellyfin Discord RPC

This software is made to be used as an Task or in connection with the Start Up Folder.

Current features:
  - Show Movie with release year and genres
  - Show Series name with Season and Episode number
  - It checks the user with an api request so it does not matter on which device the user is watching stuff.

Current release: https://github.com/synexTG/jellyfin-discordrpc/releases

### Installation

It requires .NET Framework 4.5.2 or higher.
1. Extract the .zip in an uncritical location (I used C:/Tasks/)
2. Go into "JellyfinDiscordRPC" and right-click the .exe
3. Click on "Send to" -> "Desktop (create shortcut)"
4. Press WIN+R and enter "shell:startup"
5. Move the created Desktop Shortcut into the start up folder
6. Another way is to use the Task Scheduler and create a Task.

### Required settings
To get the software work correctly you must enter your
1. Jellyfin Base URL (e. g. 127.0.0.1:8096)
2. Jellyfin API Key (Create this one with the admin account: {{base_url}}/web/index.html#!/apikeys.html)
3. Discord App ID
4. Jellyfin Username (The username from the account which will be tracked)

To get the Discord App ID you must create an Discord App at the Dev Portal:
https://discord.com/developers/applications

The app id is the same as the "Client ID".

To use a logo (like the jellyfin logo in the screenshot) you must upload an asset with the "image_large" key (In your app click on Rich Presence and "Art Assets").
Also the app name in this screenshot is "Jellyfin" so whatever your app name is will be displayed there.

![](https://i.imgur.com/6Mf8dr6.png)

