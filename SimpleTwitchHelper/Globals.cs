using System;
using System.IO;
using System.Windows;
using SimpleLoggingSystem;
using TwitchCSharp.Clients;

namespace SimpleTwitchHelper
{
    public class Globals
    {
        public const string CreateAuthKeyLink = "https://api.twitch.tv/kraken/oauth2/authorize?response_type=token&client_id=57v1e4qxkot0zyw5kxannrhabp95pnf&redirect_uri=http://localhost&scope=viewing_activity_read+user_read+channel_read+channel_editor&state=c3ab8aa609ea11e793ae92361f002671";
        public const string TwitchLink = "http://www.twitch.tv/";
        public const string TweetLink = "https://twitter.com/intent/tweet?text=";
        public const string ChatPopupUrl = "http://www.twitch.tv/{0}/chat?popout=";
        public const string ClientId = "57v1e4qxkot0zyw5kxannrhabp95pnf";
        public const int PullDataRate = 10;

        public static readonly string AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static readonly string MyFolderPath = Path.Combine(AppdataPath, "SimpleTwitchHelper");
        public static readonly string ConfigFile = Path.Combine(MyFolderPath, "config.yml");
        public static readonly string CountdownFile = Path.Combine(MyFolderPath, "countdown.txt");
        public static readonly string LogFile = Path.Combine(MyFolderPath, "log.txt");

        public static Logger Logger;
        public static Config Config;
        public static TwitchAuthenticatedClient Client;

        public static TMIApi.TMIApi TmiApi = new TMIApi.TMIApi();
        public static TwitchStatus Status = new TwitchStatus();
    }
}