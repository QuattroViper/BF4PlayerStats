using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web.Script.Serialization;
using JSONUtils;
using System.Windows.Forms;
using System.ComponentModel;

namespace JSONUtils
{

    public class Next
    {
        public int nr { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public int needed { get; set; }
        public int curr { get; set; }
        public int relNeeded { get; set; }
        public int relCurr { get; set; }
        public double relProg { get; set; }
    }

    public class Rank
    {
        public int nr { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public int needed { get; set; }
        public Next next { get; set; }
    }

    public class Player
    {
        public int id { get; set; }
        public string game { get; set; }
        public string plat { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public long dateCheck { get; set; }
        public long dateUpdate { get; set; }
        public long dateCreate { get; set; }
        public long dateStreak { get; set; }
        public string lastDay { get; set; }
        public string country { get; set; }
        public object countryName { get; set; }
        public Rank rank { get; set; }
        public int score { get; set; }
        public int timePlayed { get; set; }
        public string uId { get; set; }
        public string uName { get; set; }
        public object uGava { get; set; }
        public long udCreate { get; set; }
        public string privacy { get; set; }
        public string blPlayer { get; set; }
        public string blUser { get; set; }
        public bool editable { get; set; }
        public bool viewable { get; set; }
        public bool adminable { get; set; }
        public bool linked { get; set; }
    }

    public class Reset
    {
        public int lastReset { get; set; }
        public int score { get; set; }
        public int timePlayed { get; set; }
        public int timePlayedSinceLastReset { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int shotsFired { get; set; }
        public int shotsHit { get; set; }
        public int numLosses { get; set; }
        public int numWins { get; set; }
    }

    public class Scores
    {
        public int score { get; set; }
        public int award { get; set; }
        public int bonus { get; set; }
        public int unlock { get; set; }
        public int vehicle { get; set; }
        public int team { get; set; }
        public int objective { get; set; }
        public int squad { get; set; }
        public int general { get; set; }
        public int totalScore { get; set; }
        public int rankScore { get; set; }
        public int combatScore { get; set; }
    }

    public class Mode
    {
        public long id { get; set; }
        public int score { get; set; }
        public string name { get; set; }
    }

    public class Assault
    {
        public int id { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public int stars { get; set; }
        public double spm { get; set; }
        public string name { get; set; }
    }

    public class Engineer
    {
        public int id { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public int stars { get; set; }
        public double spm { get; set; }
        public string name { get; set; }
    }

    public class Support
    {
        public int id { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public int stars { get; set; }
        public double spm { get; set; }
        public string name { get; set; }
    }

    public class Recon
    {
        public int id { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public int stars { get; set; }
        public double spm { get; set; }
        public string name { get; set; }
    }

    public class Commander
    {
        public int id { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public int stars { get; set; }
        public double spm { get; set; }
        public string name { get; set; }
    }

    public class Kits
    {
        public Assault assault { get; set; }
        public Engineer engineer { get; set; }
        public Support support { get; set; }
        public Recon recon { get; set; }
        public Commander commander { get; set; }
    }

    public class Extra
    {
        public double kdr { get; set; }
        public double wlr { get; set; }
        public double spm { get; set; }
        public double gspm { get; set; }
        public double kpm { get; set; }
        public double sfpm { get; set; }
        public double hkp { get; set; }
        public double khp { get; set; }
        public double accuracy { get; set; }
        public int roundsFinished { get; set; }
        public int vehicleTime { get; set; }
        public int vehicleKills { get; set; }
        public int weaponTime { get; set; }
        public int weaponKills { get; set; }
        public int unknownKills { get; set; }
        public double weaTimeP { get; set; }
        public double weaKillsP { get; set; }
        public double weaKpm { get; set; }
        public double vehTimeP { get; set; }
        public double vehKillsP { get; set; }
        public double vehKpm { get; set; }
        public int ribbons { get; set; }
        public int ribbonsTotal { get; set; }
        public int ribbonsUnique { get; set; }
        public int medals { get; set; }
        public int medalsTotal { get; set; }
        public int medalsUnique { get; set; }
        public int assignments { get; set; }
        public int assignmentsTotal { get; set; }
        public double ribpr { get; set; }
    }

    public class Stats
    {
        public Reset reset { get; set; }
        public Scores scores { get; set; }
        public int skill { get; set; }
        public int elo { get; set; }
        public int rank { get; set; }
        public int timePlayed { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int headshots { get; set; }
        public int shotsFired { get; set; }
        public int shotsHit { get; set; }
        public int suppressionAssists { get; set; }
        public int avengerKills { get; set; }
        public int saviorKills { get; set; }
        public int nemesisKills { get; set; }
        public int numRounds { get; set; }
        public int numLosses { get; set; }
        public int numWins { get; set; }
        public int killStreakBonus { get; set; }
        public int nemesisStreak { get; set; }
        public int mcomDefendKills { get; set; }
        public int resupplies { get; set; }
        public int repairs { get; set; }
        public int heals { get; set; }
        public int revives { get; set; }
        public double longestHeadshot { get; set; }
        public int longestWinStreak { get; set; }
        public int flagDefend { get; set; }
        public int flagCaptures { get; set; }
        public int killAssists { get; set; }
        public int vehiclesDestroyed { get; set; }
        public int vehicleDamage { get; set; }
        public int dogtagsTaken { get; set; }
        public int streak { get; set; }
        public int bestStreak { get; set; }
        public List<Mode> modes { get; set; }
        public Kits kits { get; set; }
        public Extra extra { get; set; }
    }

    public class Stat
    {
        public int? score { get; set; }
        public int time { get; set; }
        public int kills { get; set; }
        public int hs { get; set; }
        public int hits { get; set; }
        public int shots { get; set; }
    }

    public class Extra2
    {
        public double kpm { get; set; }
        public double spm { get; set; }
        public double sfpm { get; set; }
        public double hkp { get; set; }
        public double accuracy { get; set; }
    }

    public class WeaponCategory
    {
        public string name { get; set; }
        public Stat stat { get; set; }
        public Extra2 extra { get; set; }
    }

    public class Stat2
    {
        public int destroys { get; set; }
        public int time { get; set; }
        public int kills { get; set; }
        public int? score { get; set; }
    }

    public class Extra3
    {
        public double kpm { get; set; }
        public double spm { get; set; }
    }

    public class VehicleCategory
    {
        public string id { get; set; }
        public string name { get; set; }
        public Stat2 stat { get; set; }
        public Extra3 extra { get; set; }
    }

    public class RootObject
    {
        public Player player { get; set; }
        public Stats stats { get; set; }
        public List<WeaponCategory> weaponCategory { get; set; }
        public List<VehicleCategory> vehicleCategory { get; set; }
    }
}


namespace Battlefield_4_stats
{


    class DownloadHandlerBF4Stats
    {

        static public RootObject DownloadInfo(string Name)
        {
            RootObject rootobject = null;           
            WebClient playerJSON = new WebClient();
            string json = playerJSON.DownloadString("http://api.bf4stats.com/api/playerInfo?plat=pc&name=" + Name + "&output=json&opt=details,stats,extra,weaponCategory,urls,vehicleCategory,progress");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            rootobject = ser.Deserialize<RootObject>(json);                   
            return rootobject;
        }
      
    }
}
