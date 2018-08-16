using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battle4ServerSats;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Battle4ServerSats
{

    public class ExtendedInfo
    {
        public string message { get; set; }
        public string bannerUrl { get; set; }
        public string desc { get; set; }
    }

    //here

    public class __invalid_type__1
    {
        public int current { get; set; }
        public int max { get; set; }
    }

    public class __invalid_type__2
    {
        public int current { get; set; }
        public int max { get; set; }
    }

    public class __invalid_type__4
    {
        public int current { get; set; }
        public int max { get; set; }
    }

    public class __invalid_type__8
    {
        public int current { get; set; }
        public int max { get; set; }
    }

    public class Slots
    {
        public __invalid_type__8 __invalid_name__8 { get; set; }
        public __invalid_type__1 __invalid_name__1 { get; set; }
        public __invalid_type__2 __invalid_name__2 { get; set; }
        public __invalid_type__4 __invalid_name__4 { get; set; }
    }

    public class Settings
    {
        public int vgmc { get; set; }
        public int gmwp { get; set; }
        public int vinb { get; set; }
        public int vfrm { get; set; }
        public int v3ca { get; set; }
        public int vnta { get; set; }
        public int vtbr { get; set; }
        public int vaba { get; set; }
        public int vmst { get; set; }
        public int vprc { get; set; }
        public int vmsp { get; set; }
        public int vrlc { get; set; }
        public int v3sp { get; set; }
        public int osls { get; set; }
        public int aaro { get; set; }
        public int vprp { get; set; }
        public int vprt { get; set; }
        public int vbdm { get; set; }
        public int vicc { get; set; }
        public int vvsa { get; set; }
        public int vvsd { get; set; }
        public int vkca { get; set; }
        public int vnip { get; set; }
        public int vtkk { get; set; }
        public int vhit { get; set; }
        public int vnit { get; set; }
        public int vrtl { get; set; }
        public int vtkc { get; set; }
        public int vhud { get; set; }
        public int vmin { get; set; }
        public int vrhe { get; set; }
        public int vcmd { get; set; }
        public int vrsp { get; set; }
        public int vshe { get; set; }
        public int vffi { get; set; }
        public int aasl { get; set; }
        public int vmpl { get; set; }
        public int vprb { get; set; }
        public int vsbb { get; set; }
    }

    public class Map
    {
        public string mapMode { get; set; }
        public string map { get; set; }
        public int mapVariant { get; set; }
    }

    public class Maps
    {
        public List<Map> maps { get; set; }
        public int currentMapRound { get; set; }
        public int nextMapIndex { get; set; }
        public int currentMapIndex { get; set; }
        public int numberMapRounds { get; set; }
    }

    public class SERVERINFO
    {
        public string map { get; set; }
        public string gameId { get; set; }
        public List<object> gameExpansions { get; set; }
        public string mapMode { get; set; }
        public string ip { get; set; }
        public string matchId { get; set; }
        public string protocolVersionString { get; set; }
        public ExtendedInfo extendedInfo { get; set; }
        public int game { get; set; }
        public int ranked { get; set; }
        public int online { get; set; }
        public int platform { get; set; }
        public int tickRateMax { get; set; }
        public int updatedAt { get; set; }
        public Slots slots { get; set; }
        public string guid { get; set; }
        public int port { get; set; }
        public int punkbuster { get; set; }
        public int playlist { get; set; }
        public string gameExpansion { get; set; }
        public string name { get; set; }
        public Settings settings { get; set; }
        public int fairfight { get; set; }
        public int region { get; set; }
        public int mapVariant { get; set; }
        public int ping { get; set; }
        public int serverType { get; set; }
        public string experience { get; set; }
        public int tickRate { get; set; }
        public int hasPassword { get; set; }
        public Maps maps { get; set; }
        public string secret { get; set; }
        public int preset { get; set; }
        public string pingSite { get; set; }
        public string country { get; set; }
    }

    public class OnlineGame
    {
        public int platform { get; set; }
        public int game { get; set; }
        public string personaId { get; set; }
    }

    public class PlayingMp
    {
        public string gameId { get; set; }
        public List<object> gameExpansions { get; set; }
        public string gameMode { get; set; }
        public string serverGuid { get; set; }
        public int game { get; set; }
        public string levelName { get; set; }
        public string personaId { get; set; }
        public string serverName { get; set; }
        public int experience { get; set; }
        public int platform { get; set; }
        public int role { get; set; }
    }

    public class Presence
    {
        public OnlineGame onlineGame { get; set; }
        public bool isOnline { get; set; }
        public string userId { get; set; }
        public PlayingMp playingMp { get; set; }
        public int updatedAt { get; set; }
        public bool isPlaying { get; set; }
        public string presenceStates { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string gravatarMd5 { get; set; }
        public string userId { get; set; }
        public int createdAt { get; set; }
        public Presence presence { get; set; }
    }

    public class Games
    {
    }

    public class Persona
    {
        public string picture { get; set; }
        public string userId { get; set; }
        public User user { get; set; }
        public int updatedAt { get; set; }
        public string firstPartyId { get; set; }
        public string personaId { get; set; }
        public string personaName { get; set; }
        public string gamesLegacy { get; set; }
        public string @namespace { get; set; }
        public string gamesJson { get; set; }
        public Games games { get; set; }
        public string clanTag { get; set; }
    }

    public class SERVERPLAYER
    {
        public string personaId { get; set; }
        public Persona persona { get; set; }
        public int platform { get; set; }
        public int game { get; set; }
        public string gameId { get; set; }
        public string guid { get; set; }
    }

    public class Message
    {
        public SERVERINFO SERVER_INFO { get; set; }
        public object friendsWithFavServer { get; set; }
        public List<SERVERPLAYER> SERVER_PLAYERS { get; set; }
        public bool isFavorite { get; set; }
    }

    public class Data
    {
    }

    public class RootObject3
    {
        public string type { get; set; }
        public Message message { get; set; }
        public Data data { get; set; }
    }
}

namespace Battlefield_4_stats
{
    class DownloadHandlerServers
    {
        static public List<RootObject3> DownloadInfo()
        {
            List<RootObject3> rootObjects = new List<RootObject3>();
            List<string> ServerGUIDs = FileHandler.ServerGUID();
            foreach (var GUID in ServerGUIDs)
            {
                WebClient playerJSON = new WebClient();
                string json = playerJSON.DownloadString("http://battlelog.battlefield.com/bf4/servers/show/pc/" + GUID + "/?json=1");
                JavaScriptSerializer ser = new JavaScriptSerializer();
                RootObject3 rootobejct3 = ser.Deserialize<RootObject3>(json);
                rootObjects.Add(rootobejct3);
            }
            
            return rootObjects;
        }
    }
}
