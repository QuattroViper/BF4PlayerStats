using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONUtilsBattlelog;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace JSONUtilsBattlelog
{
    public class GameModeServiceStarsGold
    {
    }

    public class KitLosses
    {
    }

    public class GameModesScore
    {
        public string __invalid_name__32 { get; set; }
        public string __invalid_name__1 { get; set; }
        public string __invalid_name__2 { get; set; }
        public int __invalid_name__33554432 { get; set; }
        public string __invalid_name__68719476736 { get; set; }
        public string __invalid_name__64 { get; set; }
        public string __invalid_name__1024 { get; set; }
        public int __invalid_name__524288 { get; set; }
        public int __invalid_name__134217728 { get; set; }
        public string __invalid_name__2097152 { get; set; }
        public string __invalid_name__8 { get; set; }
        public int __invalid_name__8388608 { get; set; }
        public int __invalid_name__512 { get; set; }
        public string __invalid_name__137438953472 { get; set; }
        public int __invalid_name__34359738368 { get; set; }
        public int __invalid_name__16777216 { get; set; }
        public int __invalid_name__67108864 { get; set; }
    }

    public class KitMaxHeadshotsInRound
    {
    }

    public class KitDeployments
    {
    }

    public class KitMaxMeleeKillsInRound
    {
    }

    public class KitLongestHeadshot
    {
    }

    public class GameModeServiceStarsBronze
    {
    }

    public class KitMeleeKills
    {
    }

    public class KitTimesInPercentage
    {
        public double __invalid_name__8 { get; set; }
        public double __invalid_name__1 { get; set; }
        public double __invalid_name__2 { get; set; }
        public double __invalid_name__2048 { get; set; }
        public double __invalid_name__32 { get; set; }
    }

    public class KitScores
    {
        public string __invalid_name__8 { get; set; }
        public string __invalid_name__1 { get; set; }
        public string __invalid_name__2 { get; set; }
        public string __invalid_name__2048 { get; set; }
        public string __invalid_name__32 { get; set; }
    }

    public class VehicleScores
    {
        public string __invalid_name__32 { get; set; }
        public int __invalid_name__1 { get; set; }
        public string __invalid_name__2 { get; set; }
        public string __invalid_name__4 { get; set; }
        public string __invalid_name__8 { get; set; }
        public string __invalid_name__16 { get; set; }
    }

    public class ServiceStarsGameMode
    {
        public int serviceStars { get; set; }
        public double serviceStarsProgress { get; set; }
        public string actualValue { get; set; }
        public object progressCodeNeeded { get; set; }
        public string codeNeeded { get; set; }
        public object tier { get; set; }
        public int valueNeeded { get; set; }
        public object name { get; set; }
    }

    public class ServiceStarsProgress
    {
        public double __invalid_name__8 { get; set; }
        public double __invalid_name__1 { get; set; }
        public double __invalid_name__2 { get; set; }
        public double __invalid_name__2048 { get; set; }
        public double __invalid_name__32 { get; set; }
    }

    public class KitWins
    {
    }

    public class KitTimes
    {
        public string __invalid_name__8 { get; set; }
        public string __invalid_name__1 { get; set; }
        public string __invalid_name__2 { get; set; }
        public string __invalid_name__2048 { get; set; }
        public string __invalid_name__32 { get; set; }
    }

    public class KitKills
    {
    }

    public class KitMaxScoreInRound
    {
    }

    public class KitDeaths
    {
    }

    public class KitHeadshots
    {
    }

    public class KitKillStreak
    {
    }

    public class ServiceStars
    {
        public int __invalid_name__8 { get; set; }
        public int __invalid_name__1 { get; set; }
        public int __invalid_name__2 { get; set; }
        public int __invalid_name__2048 { get; set; }
        public int __invalid_name__32 { get; set; }
    }

    public class GameModeServiceStarsSilver
    {
    }

    public class KitMaxKillsInRound
    {
    }

    public class GeneralStats
    {
        public double PDWHeadshots { get; set; }
        public object timeDead { get; set; }
        public object mortarUser { get; set; }
        public GameModeServiceStarsGold gameModeServiceStarsGold { get; set; }
        public double quitPercentage { get; set; }
        public object cp_deaths { get; set; }
        public object sc_heist { get; set; }
        public string skill { get; set; }
        public double assaultRifleAccuracy { get; set; }
        public string kills_assault { get; set; }
        public int elo { get; set; }
        public object sc_hostage { get; set; }
        public string sc_award { get; set; }
        public object cp_skill { get; set; }
        public string revives { get; set; }
        public KitLosses kitLosses { get; set; }
        public object maxMeleeKillsInRound { get; set; }
        public object rushWlr { get; set; }
        public GameModesScore gameModesScore { get; set; }
        public object cashEarned { get; set; }
        public string teamdeathmatch { get; set; }
        public double rocketLauncherAccuracy { get; set; }
        public string kills { get; set; }
        public double kdRatio { get; set; }
        public string sc_bonus { get; set; }
        public object cs_wins { get; set; }
        public KitMaxHeadshotsInRound kitMaxHeadshotsInRound { get; set; }
        public int rsNumLosses { get; set; }
        public string assaultRifleKills { get; set; }
        public object sc_hotwire { get; set; }
        public object flagrunner { get; set; }
        public int rsKills { get; set; }
        public KitDeployments kitDeployments { get; set; }
        public object kdRatioDelta { get; set; }
        public object sc_bloodmoney { get; set; }
        public object squadRushWlr { get; set; }
        public KitMaxMeleeKillsInRound kitMaxMeleeKillsInRound { get; set; }
        public double PDWKills { get; set; }
        public object sc_bountyhunter { get; set; }
        public object spm_engineer { get; set; }
        public double accuracy { get; set; }
        public string sc_unlock { get; set; }
        public object sc_turfwar { get; set; }
        public string conquestlarge { get; set; }
        public KitLongestHeadshot kitLongestHeadshot { get; set; }
        public object reDeploys { get; set; }
        public object clubRepution { get; set; }
        public double LMGAccuracy { get; set; }
        public object sc_commander { get; set; }
        public int carrierassault { get; set; }
        public object rushLosses { get; set; }
        public string resupplies { get; set; }
        public object spm_support { get; set; }
        public string conquest_ladder { get; set; }
        public string repairs { get; set; }
        public string shotsFired { get; set; }
        public object maxHeadshotsInRound { get; set; }
        public GameModeServiceStarsBronze gameModeServiceStarsBronze { get; set; }
        public object motionSensorSpots { get; set; }
        public string LMGKills { get; set; }
        public string score { get; set; }
        public KitMeleeKills kitMeleeKills { get; set; }
        public int timePlayedDelta { get; set; }
        public KitTimesInPercentage kitTimesInPercentage { get; set; }
        public string timePlayed { get; set; }
        public string rank { get; set; }
        public string kills_engineer { get; set; }
        public KitScores kitScores { get; set; }
        public string suppressionAssists { get; set; }
        public int rsDeaths { get; set; }
        public string assaultRifleHeadshots { get; set; }
        public int carrierassaultsmall { get; set; }
        public double killsPerMinute { get; set; }
        public string sniperRifleKills { get; set; }
        public int timePlayedSinceLastReset { get; set; }
        public int chainlink { get; set; }
        public object winPercentage { get; set; }
        public object tdmWlr { get; set; }
        public object sc_operator { get; set; }
        public VehicleScores vehicleScores { get; set; }
        public double wlRatio { get; set; }
        public object tdmLosses { get; set; }
        public string numRounds { get; set; }
        public object maxKillsInRound { get; set; }
        public string killStreakBonus { get; set; }
        public int lastReset { get; set; }
        public object sc_deathmatch { get; set; }
        public object spm_recon { get; set; }
        public int rsShotsFired { get; set; }
        public string shotsHit { get; set; }
        public List<ServiceStarsGameMode> serviceStarsGameModes { get; set; }
        public string numLosses { get; set; }
        public object spm_assault { get; set; }
        public object squadDMLosses { get; set; }
        public object maxScoreInRound { get; set; }
        public string sqdm { get; set; }
        public string engineer { get; set; }
        public ServiceStarsProgress serviceStarsProgress { get; set; }
        public double rsScorePerMinute { get; set; }
        public int rsScore { get; set; }
        public string conquest { get; set; }
        public string dogtagsTaken { get; set; }
        public KitWins kitWins { get; set; }
        public object rushWins { get; set; }
        public string sc_vehicle { get; set; }
        public object cp_wins { get; set; }
        public object cs_skill { get; set; }
        public string sc_team { get; set; }
        public string totalScore { get; set; }
        public string heals { get; set; }
        public string obliteration { get; set; }
        public KitTimes kitTimes { get; set; }
        public double longestHeadshot { get; set; }
        public object conquestWlr { get; set; }
        public object meleeKills { get; set; }
        public object longestWinStreak { get; set; }
        public string support { get; set; }
        public string mcomDefendKills { get; set; }
        public object cs_deaths { get; set; }
        public object vehiclesDestroyedAssists { get; set; }
        public object squadDMWins { get; set; }
        public KitKills kitKills { get; set; }
        public object sc_mechanic { get; set; }
        public KitMaxScoreInRound kitMaxScoreInRound { get; set; }
        public string kills_support { get; set; }
        public object cp_kills { get; set; }
        public KitDeaths kitDeaths { get; set; }
        public object squadRushLosses { get; set; }
        public string flagDefend { get; set; }
        public string LMGHeadshots { get; set; }
        public string domination { get; set; }
        public string saviorKills { get; set; }
        public string nemesisStreak { get; set; }
        public int elimination { get; set; }
        public string numWins { get; set; }
        public string killAssists { get; set; }
        public object sc_enforcer { get; set; }
        public object conquestWins { get; set; }
        public int scorePerMinuteDelta { get; set; }
        public KitHeadshots kitHeadshots { get; set; }
        public string rush { get; set; }
        public double sniperRifleAccuracy { get; set; }
        public int sc_objective { get; set; }
        public int rsTimePlayed { get; set; }
        public double antiGroundSoldier { get; set; }
        public int rsShotsHit { get; set; }
        public string recon { get; set; }
        public string nemesisKills { get; set; }
        public string sc_squad { get; set; }
        public string vehicleDamage { get; set; }
        public int capturetheflag { get; set; }
        public KitKillStreak kitKillStreak { get; set; }
        public ServiceStars serviceStars { get; set; }
        public object sc_hacker { get; set; }
        public string deaths { get; set; }
        public object sc_professional { get; set; }
        public string sc_general { get; set; }
        public string sniperRifleHeadshots { get; set; }
        public string commander { get; set; }
        public int carrierassaultlarge { get; set; }
        public object tdmWins { get; set; }
        public GameModeServiceStarsSilver gameModeServiceStarsSilver { get; set; }
        public object cashPerMinute { get; set; }
        public string headshots { get; set; }
        public object cs_loses { get; set; }
        public object sc_squadheist { get; set; }
        public int rsNumWins { get; set; }
        public int airsuperiority { get; set; }
        public object squadDmWlr { get; set; }
        public string sqobliteration { get; set; }
        public int gunmaster { get; set; }
        public string kills_recon { get; set; }
        public object sc_hit { get; set; }
        public string rankScore { get; set; }
        public KitMaxKillsInRound kitMaxKillsInRound { get; set; }
        public string flagCaptures { get; set; }
        public int scoreDelta { get; set; }
        public string vehiclesDestroyed { get; set; }
        public int scorePerMinute { get; set; }
        public string assault { get; set; }
        public string combatScore { get; set; }
        public string avengerKills { get; set; }
        public object sc_capturetheflag { get; set; }
        public double antiAirSoldier { get; set; }
        public int scoreMultiplier { get; set; }
        public double mcomDestroy { get; set; }
        public double PDWAccuracy { get; set; }
        public object squadRushWins { get; set; }
        public object cp_loses { get; set; }
        public object conquestLosses { get; set; }
        public object cs_kills { get; set; }
    }

    public class Data
    {
        public int personaId { get; set; }
        public int platformInt { get; set; }
        public GeneralStats generalStats { get; set; }
        public string statsTemplate { get; set; }
        public bool mySoldier { get; set; }
    }

    public class RootObject2
    {
        public string type { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }
}

namespace Battlefield_4_stats
{
    class DownloadHandlerBattlelog
    {

        static public RootObject2 DownloadInfo(string Name)
        {
            string PlayerID = "";
            List<string> PlayerInfo = FileHandler.PlayerIDs();
            foreach (var Player in PlayerInfo)
            {
                string[] Splitted = Player.Split(','); 
                if (Name == Splitted[0])
                {
                    PlayerID = Splitted[1];
                }
            }

            WebClient playerJSON = new WebClient();
            string json = playerJSON.DownloadString("http://battlelog.battlefield.com/bf4/warsawdetailedstatspopulate/" + PlayerID + "/1/");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            RootObject2 rootobejct2 = ser.Deserialize<RootObject2>(json);
            return rootobejct2;
        }

        static public RootObject2 DownloadServerPlayerInfo(string PlayerID)
        {
            WebClient playerJSON = new WebClient();
            string json = playerJSON.DownloadString("http://battlelog.battlefield.com/bf4/warsawdetailedstatspopulate/" + PlayerID + "/1/");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            RootObject2 rootobejct2 = ser.Deserialize<RootObject2>(json);
            return rootobejct2;
        }
    }
}
