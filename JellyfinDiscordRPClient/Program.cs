using DiscordRPC;
using JellyfinDiscordRPClient.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;

namespace JellyfinDiscordRPClient
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyCustomApplicationContext());

        }

        public class MyCustomApplicationContext : ApplicationContext
        {
            static RestClient client;
            static DiscordRpcClient RPCclient;
            static System.Timers.Timer timer;
            static RestRequest request;
            private NotifyIcon trayIcon;
            static int error = 0;
            string jellyfin_url = "";
            static string jellyfin_apikey = "";
            static string discord_appid = "";
            static string jellyfin_username = "";

            public MyCustomApplicationContext()
            {
                jellyfin_url = File.ReadLines("settings.conf").Skip(0).Take(1).First().Replace("jellyfin_url = ", "");
                jellyfin_apikey = File.ReadLines("settings.conf").Skip(1).Take(1).First().Replace("jellyfin_apikey = ", "");
                discord_appid = File.ReadLines("settings.conf").Skip(2).Take(1).First().Replace("discord_appid = ", "");
                jellyfin_username = File.ReadLines("settings.conf").Skip(3).Take(1).First().Replace("jellyfin_username = ", "");
                // Initialize Tray Icon
                trayIcon = new NotifyIcon()
                {
                    Icon = Resources.AppIcon,
                    ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", Exit)
            }),
                    Visible = true
                };
                RPCclient = new DiscordRpcClient(discord_appid);
                timer = new System.Timers.Timer(5000);
                timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
                timer.Start();
                client = new RestClient(jellyfin_url);
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                client.Timeout = -1;
            }

            void Exit(object sender, EventArgs e)
            {
                // Hide tray icon, otherwise it will remain shown until user mouses over it
                trayIcon.Visible = false;

                Application.Exit();
            }

            static void timer_Elapsed(object sender, ElapsedEventArgs e)
            {
                try
                {
                    request = new RestRequest("/Sessions", Method.GET);
                    request.AddParameter("api_key", jellyfin_apikey);
                    IRestResponse response = client.Execute(request);
                    var jsonSerializerSettings = new JsonSerializerSettings();
                    jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                    List<Sessions> mySessions = JsonConvert.DeserializeObject<List<Sessions>>(response.Content, jsonSerializerSettings);
                    foreach (Sessions myRootObject in mySessions)
                    {
                        if (myRootObject.UserName != null && myRootObject.UserName.Equals(jellyfin_username))
                        {
                            if (myRootObject.NowPlayingItem != null)
                            {
                                if (!RPCclient.IsInitialized)
                                {
                                    RPCclient = new DiscordRpcClient(discord_appid);
                                    RPCclient.Initialize();
                                }
                                error = 0;
                                if (myRootObject.NowPlayingItem.Type.Equals("Movie"))
                                {
                                    string allGenres = "";
                                    foreach(string myGenre in myRootObject.NowPlayingItem.Genres)
                                    {
                                        if(allGenres.Equals(""))
                                        {
                                            allGenres = allGenres + myGenre; 
                                        } else
                                        {
                                            allGenres = allGenres + ", " + myGenre;
                                        }
                                    }
                                    RPCclient.SetPresence(new RichPresence()
                                    {
                                        Details = "Titel: " + myRootObject.NowPlayingItem.Name + " (" + myRootObject.NowPlayingItem.PremiereDate.Year + ")",
                                        State =  "Genre: " + allGenres,
                                        Assets = new Assets()
                                        {
                                            LargeImageKey = "image_large",
                                            LargeImageText = "Jellyfin Media System",
                                            SmallImageKey = "image_small"
                                        }
                                    });
                                }
                                else
                                {
                                    RPCclient.SetPresence(new RichPresence()
                                    {
                                        Details = myRootObject.NowPlayingItem.SeriesName + " - St. " + Regex.Match(myRootObject.NowPlayingItem.SeasonName, @"\d+").Value + " Flg. " + myRootObject.NowPlayingItem.IndexNumber,
                                        State = myRootObject.NowPlayingItem.Name,
                                        Assets = new Assets()
                                        {
                                            LargeImageKey = "image_large",
                                            LargeImageText = "Image Large Text",
                                            SmallImageKey = "image_small"
                                        }
                                    });
                                }
                            } else
                            {
                                error = error + 1;
                            }
                        } else
                        {
                            error = error + 1;
                        }
                    }

                    if(error > 3)
                    {
                        if (RPCclient.IsInitialized)
                        {
                            RPCclient.Deinitialize();
                        }
                        error = 0;
                    }
                }
                catch (Exception ex) {

                    throw ex;
                }
            }
        }
    }
}
