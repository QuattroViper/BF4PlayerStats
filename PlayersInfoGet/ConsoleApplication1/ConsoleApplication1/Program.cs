using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    #region JSONClasses
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

    public class RootObject
    {
        public string type { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    #endregion
    enum Menu
    {
        Teams=1,Overall,Details,Add,Previous,Export,Exit
    }

    enum Colours
    {
        One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, OneOne, TwoTwo, ThreeThree, FourFour, FiveFive, SixSix, SevenSeven, EightEight, NineNine, tenTen
    }
    class Program
    {
        #region MaximiseWindow
        [DllImport("kernel32.dll", ExactSpelling = true)]

        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        #endregion
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
            Console.Title = "Battlefield 4 Player Stats and Team Manager";

            List<string> NewStats = new List<string>();
            string[] splitted = new string[2];
            List<String> Stats = new List<string>();
            List<string> GuiID = new List<string>();
            List<string> PlayerName = new List<string>();
            FileStream IDInFile = new FileStream("PlayerID.txt", FileMode.Open, FileAccess.Read);
            StreamReader Read = new StreamReader(IDInFile);            
            string Lines = " ";
            while ((Lines = Read.ReadLine()) != null)
            {
                splitted = Lines.Split(',');
                GuiID.Add(splitted[0]);
                PlayerName.Add(splitted[1]);
            }
            Read.Close();

            #region Process JSON
            Console.WriteLine();
            Console.Write("Do want the new updated stats or old Stats (NEW/OLD) : ");
            string YesNo = Console.ReadLine().ToUpper();
            if (YesNo == "NEW")
            {

                for (int i = 0; i < GuiID.Count; i++)
                {
                    Console.Clear();
                    string URLPrefix = "http://";
                    string URL = string.Format("{0}battlelog.battlefield.com/bf4/warsawdetailedstatspopulate/{1}/1/", URLPrefix, GuiID[i]);
                    using (var webClient = new System.Net.WebClient())
                    {
                        Console.WriteLine(" Downloading player {0} Data", i + 1);
                        string json = webClient.DownloadString(URL);
                        Console.WriteLine(" Serializing Player {0} Data", i + 1);
                        JavaScriptSerializer ser = new JavaScriptSerializer();
                        Console.WriteLine(" Processing Player {0} Data", i + 1);
                        RootObject ObjRoot = ser.Deserialize<RootObject>(json);
                        System.Threading.Thread.Sleep(500);
                        
                        double CalculationForTeam = Math.Round((((double.Parse(ObjRoot.data.generalStats.timePlayed) / 3600) / int.Parse(ObjRoot.data.generalStats.rank)) * ObjRoot.data.generalStats.scorePerMinute), 2);

                        string BestClass = "";
                        double ScorePerMinute = ObjRoot.data.generalStats.scorePerMinute;
                        int Deaths = int.Parse(ObjRoot.data.generalStats.deaths);

                        double assaultAccuracy = ObjRoot.data.generalStats.assaultRifleAccuracy;
                        int Assaultkills = int.Parse(ObjRoot.data.generalStats.assaultRifleKills);
                        double AssaultClassCalculation = (ScorePerMinute * assaultAccuracy * Assaultkills / (Deaths));

                        double Reconaccuracy = ObjRoot.data.generalStats.sniperRifleAccuracy;
                        int Reconkills = int.Parse(ObjRoot.data.generalStats.sniperRifleKills);
                        double ReconClassCalculation = (ScorePerMinute * Reconaccuracy * Reconkills / (Deaths));

                        double LMGAccuracy = ObjRoot.data.generalStats.LMGAccuracy;
                        int LMGkills = int.Parse(ObjRoot.data.generalStats.LMGKills);
                        double CarbineClassCalculation = (ScorePerMinute * LMGAccuracy * LMGkills / (Deaths));
                        if ((AssaultClassCalculation > ReconClassCalculation) && (AssaultClassCalculation > CarbineClassCalculation))
                        {
                            BestClass = "Assault";
                        }
                        else if ((ReconClassCalculation > AssaultClassCalculation) && (ReconClassCalculation > CarbineClassCalculation))
                        {
                            BestClass = "Recon";
                        }
                        else if ((CarbineClassCalculation > AssaultClassCalculation) && (CarbineClassCalculation > ReconClassCalculation))
                        {
                            BestClass = "Carbine";
                        }
                        else
                        {
                            BestClass = "Any Class";
                        }

                        string Name = PlayerName[i];
                        string Skill = ObjRoot.data.generalStats.skill;
                        string Rank = ObjRoot.data.generalStats.rank;
                        string KD = ObjRoot.data.generalStats.kdRatio.ToString();
                        string SPM = ObjRoot.data.generalStats.scorePerMinute.ToString();
                        string Time = Math.Round((double.Parse(ObjRoot.data.generalStats.timePlayed) / 3600), 1).ToString();
                        //calculationForTeam
                        string KPM = ObjRoot.data.generalStats.killsPerMinute.ToString();
                        string LongShot = ObjRoot.data.generalStats.longestHeadshot.ToString();
                        string DogTags = ObjRoot.data.generalStats.dogtagsTaken;
                        string Score = ObjRoot.data.generalStats.score;
                        //BestClass
                        string PID = GuiID[i];
                                                                                                      //  0     1      2     3   4    5     6                   7    8         9        10     11   12
                        Stats.Add(string.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}_{10}_{11}_{12}", Name, Skill, Rank, KD, SPM, Time, CalculationForTeam, KPM, LongShot, DogTags, Score, PID, BestClass));
                       
                        NewStats = Stats;
                    }
                }
            }
            else
            {

                Stats = PreRun();
                NewStats = Stats;
                if (GuiID.Count != Stats.Count)
                {
                    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                    Console.WriteLine("The amount of players have been changed.");                
                    Console.WriteLine("Please retrieve the new stats.");
                    Console.WriteLine("The application will now exit.");
                    System.Threading.Thread.Sleep(6000);
                    Environment.Exit(0);
                }
                Read.Close();
            }

            #endregion

            #region Menu
            Menu:
            Console.Clear();
            Console.WriteLine(@"
            
            =========================================
            |                                       |
            |           Battlefield 4 Stats         |
            |                                       |
            -----------------------------------------

            1)  Generate Teams
            2)  Overall Stats
            3)  Detailed Stats
            4)  Add Player
            5)  Compare to previous Save
            6)  Export Stats
            7)  Exit Application
            
");
            Console.Write("             Please Select a Option : ");
          
            int Choice = int.Parse(Console.ReadLine());
            Menu Option = (Menu)Choice;
            switch (Option)
            {
                case Menu.Teams:
                    Console.Clear();
                    Teams(Stats);
                    Console.WriteLine();
                    Console.WriteLine(" Press ENTER to go back");
                    Console.ReadKey();
                    goto Menu;
                case Menu.Overall:
                    Console.Clear();
                    Overall(Stats);
                    Console.WriteLine();
                    Console.WriteLine(" Press ENTER to go back");
                    Console.ReadKey();
                    goto Menu;
                case Menu.Details:
                    Console.Clear();
                    Detail(Stats);
                    Console.WriteLine();
                    Console.WriteLine(" Press ENTER to go back");
                    Console.ReadKey();
                    goto Menu;
                case Menu.Add:
                    Console.Clear();
                    Console.WriteLine();
                    AddPlayer();
                    Console.WriteLine(" Player added.");
                    Console.WriteLine(" Application will now exit.");
                    Console.WriteLine(" Please retrieve the new stats.");
                    System.Threading.Thread.Sleep(400);
                    Environment.Exit(0);                   
                    goto Menu;
                case Menu.Previous:
                    Console.Clear();
                    Console.WriteLine();
                    Compare(PreRun(),NewStats);
                    Console.WriteLine();
                    Console.WriteLine(" Press ENTER to go back");
                    Console.ReadKey();
                    goto Menu;
                case Menu.Export:
                    Export(Stats);
                    Console.WriteLine(" Exporting Stats Completed");
                    System.Threading.Thread.Sleep(1200);                 
                    goto Menu;
                case Menu.Exit:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            #endregion

            Console.ReadKey();

        }

        private static string[] Split(string SplitStats)
        {

            string[] Split = SplitStats.Split('_');
            return Split;
        }

        private static void Teams(List<string> Stats)
        {
            double[] Positions = new double[Stats.Count];
            for (int i = 0; i < Stats.Count; i++)
            {
                string[] FromSSplit = Split(Stats[i]);
                Positions[i] = double.Parse(FromSSplit[6]);
            }

            for (int i = 0; i < Stats.Count-1; i++)
            {
                for (int j = 0+i; j < Stats.Count; j++)
                {
                    if (Positions[i] < Positions[j])
                    {
                        double temp = Positions[i];
                        Positions[i] = Positions[j];
                        Positions[j] = temp;
                        string Listtemp = Stats[i];
                        Stats[i] = Stats[j];
                        Stats[j] = Listtemp;                      
                    }
                }
            }

            Console.WriteLine(" Name\t\tSkill\tRank\tCalculated Score for Ranking\tRecommended Class");
            
            Console.WriteLine(" ---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(" Wolves");
            Console.WriteLine();

            bool EnterFox = false;
            bool EnterRes = false;
            for (int i = 0; i < Stats.Count; i++)
            {
                string[] FromSSplit = Split(Stats[i]);
                if (i < 5)
                {
                    Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t\t{4}", FromSSplit[0], FromSSplit[1], FromSSplit[2], FromSSplit[6], FromSSplit[12]);                                      
                }
                else if (i < 10)
                {
                    if (EnterFox == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Foxes");
                        Console.WriteLine();
                        EnterFox = true;
                    }
                    Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t\t{4}", FromSSplit[0], FromSSplit[1], FromSSplit[2], FromSSplit[6], FromSSplit[12]);
                }
                else 
                {
                    if (EnterRes == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Reserves");
                        Console.WriteLine();
                        EnterRes = true;
                    }
                    Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t\t{4}", FromSSplit[0], FromSSplit[1], FromSSplit[2], FromSSplit[6], FromSSplit[12]);
                }
            }
            Console.WriteLine();

        }

        private static void Overall(List<string> Stats)
        {
            Console.WriteLine(@"
            1.  Skill
            2.  Rank
            3.  K/D Ratio
            4.  Score Per Minute
            5.  Time Played
");
            Console.Write("            Enter number to sort : ");
            int SortOnWhat = int.Parse(Console.ReadLine());
           
            Console.Clear();
            Stats = SortSkill(Stats, SortOnWhat);

            Console.WriteLine();
            Console.WriteLine(" Name\t\tSkill\tRank\tK/D Ratio\tScore Per Minute\tTime Played(H)");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 0; i < Stats.Count; i++)
            {
                string[] FromSSplit = Split(Stats[i]);
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t\t{4}\t\t\t{5}",FromSSplit[0], FromSSplit[1], FromSSplit[2], FromSSplit[3], FromSSplit[4], FromSSplit[5]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void Export(List<string> Stats)
        {
            using (FileStream NewText = new FileStream("Exported.txt", FileMode.Create)) { NewText.Close();  }
            FileStream OutFile = new FileStream("Exported.txt", FileMode.Append, FileAccess.Write);
            StreamWriter Write = new StreamWriter(OutFile);
            for (int i = 0; i < Stats.Count; i++)
            {
                Write.WriteLine(Stats[i]);
            }
            Write.Close();
        }

        private static void Detail(List<string> Stats)
        {

            Console.WriteLine(@"
            1.  Skill
            2.  Rank
            3.  Skills Per Minute
            4.  Longest Headshot
            5.  Dog Tags Taken
            6.  Score
");
            Console.Write("            Enter number to sort : ");
            int SortOnWhat = int.Parse(Console.ReadLine());
            Console.Clear();
            if (SortOnWhat > 2)
            {
                SortOnWhat = SortOnWhat + 4;
            }
            
            Stats = SortSkill(Stats, SortOnWhat);

            Console.WriteLine();
            Console.WriteLine(" Name\t\tSkill\tRank\tKills Per Minute\tLongest Headshot\tDog Tags Taken\tScore");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 0; i < Stats.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                string[] FromSSplit = Split(Stats[i]);
                Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t\t\t{4}\t\t\t{5}", FromSSplit[0], FromSSplit[1], FromSSplit[2], FromSSplit[7], FromSSplit[8], FromSSplit[9], FromSSplit[10]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static List<string> SortSkill(List<string> PreStats, int StatPos)
        {          
            List<double> StatSort = new List<double>();
            StatSort.Clear();
            for (int i = 0; i < PreStats.Count; i++)
            {
                string[] FromSSplit = Split(PreStats[i]);
                StatSort.Add(double.Parse(FromSSplit[StatPos]));
            }
            string Listtemp;
            for (int i = 0; i < PreStats.Count - 1; i++)
            {
                for (int j = 0 + i; j < PreStats.Count; j++)
                {
                    if (StatSort[i] < StatSort[j])
                    {
                        double stattemp = StatSort[i];
                        StatSort[i] = StatSort[j];
                        StatSort[j] = stattemp;
                        Listtemp = PreStats[i];
                        PreStats[i] = PreStats[j];
                        PreStats[j] = Listtemp;
                    }
                }
            }
                
            return PreStats;
        }

        private static void AddPlayer()
        {
            Console.WriteLine();
            Console.Write("Enter the Player's Game ID : ");
            string GameID = Console.ReadLine();
            Console.Write("Enter the Player's Game Name : ");
            string GameName = Console.ReadLine();
            FileStream OutFile = new FileStream("PlayerID.txt", FileMode.Append, FileAccess.Write);
            StreamWriter Write = new StreamWriter(OutFile);          
            Write.WriteLine(string.Format("{0},{1}",GameID,GameName));            
            Write.Close();
        }

        private static void Compare(List<string> OldStats, List<string> NewStats)
        {

            OldStats = SortSkill(OldStats, 11);
            NewStats = SortSkill(NewStats, 11);

            Console.WriteLine(@"
            1.  Skill
            2.  Rank
            3.  K/D Ratio
            4.  Score per Minute
            5.  Time Played
            6.  Clan Score
            7.  Kills Per Minute
            8.  Longest Headshot
            9.  Dogtags Taken
            10. Overall Score  
");
            Console.Write("            Enter number to sort : ");
            int SortOnWhat = int.Parse(Console.ReadLine());

            Console.Clear();
            //OldStats = SortSkill(OldStats, SortOnWhat);
            //NewStats = SortSkill(NewStats, SortOnWhat);


            List<double> StatSort = new List<double>();
            for (int i = 0; i < NewStats.Count; i++)
            {
                string[] FromSSplit = Split(NewStats[i]);
                StatSort.Add(double.Parse(FromSSplit[SortOnWhat]));
            }
            for (int i = 0; i < NewStats.Count - 1; i++)
            {
                for (int j = 0 + i; j < NewStats.Count; j++)
                {
                    if (StatSort[i] < StatSort[j])
                    {
                        double stattemp = StatSort[i];
                        StatSort[i] = StatSort[j];
                        StatSort[j] = stattemp;
                        string Listtempold = OldStats[i];
                        OldStats[i] = OldStats[j];
                        OldStats[j] = Listtempold;
                        string Listtempnew = NewStats[i];
                        NewStats[i] = NewStats[j];
                        NewStats[j] = Listtempnew;
                    }
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Name           Skill            Rank             K/D              SPM              Time Played      Clan Score       KPM              Headshot         Dogtags          Overall Score");
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine();
            int[,] ComparedOneZero = new int[NewStats.Count, 13];
            int TotalPaces = 17;
            double Difference = 0;
            for (int i = 0; i < NewStats.Count; i++)
            {
                string[] FromSSplitOld = Split(OldStats[i]);
                string[] FromSSplitNew = Split(NewStats[i]);
                string Together = "";
                Console.Write(string.Format(" {0}\t",FromSSplitNew[0]));
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 1; j < FromSSplitNew.Length-2; j++)    
                {
                    if (double.Parse(FromSSplitOld[j]) > double.Parse(FromSSplitNew[j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Difference = Math.Round((double.Parse(FromSSplitNew[j]) - double.Parse(FromSSplitOld[j])), 2);
                        Together = FromSSplitNew[j] + "(" + Difference + ")";
                        for (int k = Together.Length; k < TotalPaces; k++)
                        {
                            Together = Together + " ";
                        }
                        Console.Write(Together);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (double.Parse(FromSSplitOld[j]) < double.Parse(FromSSplitNew[j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Difference = Math.Round((double.Parse(FromSSplitNew[j]) - double.Parse(FromSSplitOld[j])), 2);
                        Together = FromSSplitNew[j] + "(" + "+" + Difference + ")";
                        for (int k = Together.Length; k < TotalPaces; k++)
                        {
                            Together = Together + " ";
                        }
                        Console.Write(Together);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Difference = Math.Round((double.Parse(FromSSplitNew[j]) - double.Parse(FromSSplitOld[j])), 2);
                        Together = FromSSplitNew[j] + "(" + Difference + ")";
                        for (int k = Together.Length; k < TotalPaces; k++)
                        {
                            Together = Together + " ";
                        }
                        Console.Write(Together);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                #region EnumColours
                //Colours option = (Colours)i;
                //switch (option)
                //{
                //    case Colours.One:
                //        Console.ForegroundColor = ConsoleColor.DarkGray;
                //        break;
                //    case Colours.Two:
                //        Console.ForegroundColor = ConsoleColor.Blue;
                //        break;
                //    case Colours.Three:
                //        Console.ForegroundColor = ConsoleColor.DarkCyan;
                //        break;
                //    case Colours.Four:
                //        Console.ForegroundColor = ConsoleColor.Green;
                //        break;
                //    case Colours.Five:
                //        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                //        break;
                //    case Colours.Six:
                //        Console.ForegroundColor = ConsoleColor.White;
                //        break;
                //    case Colours.Seven:
                //        Console.ForegroundColor = ConsoleColor.DarkGreen;
                //        break;
                //    case Colours.Eight:
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        break;
                //    case Colours.Nine:
                //        Console.ForegroundColor = ConsoleColor.Yellow;
                //        break;
                //    case Colours.Ten:
                //        Console.ForegroundColor = ConsoleColor.Cyan;
                //        break;
                //    case Colours.OneOne:
                //        Console.ForegroundColor = ConsoleColor.DarkBlue;
                //        break;
                //    case Colours.TwoTwo:
                //        Console.ForegroundColor = ConsoleColor.Gray;
                //        break;
                //    case Colours.ThreeThree:
                //        Console.ForegroundColor = ConsoleColor.DarkGray;
                //        break;
                //    case Colours.FourFour:
                //        Console.ForegroundColor = ConsoleColor.Green;
                //        break;
                //    case Colours.FiveFive:
                //        Console.ForegroundColor = ConsoleColor.Blue;
                //        break;
                //    case Colours.SixSix:
                //        Console.ForegroundColor = ConsoleColor.White;
                //        break;
                //    case Colours.SevenSeven:
                //        Console.ForegroundColor = ConsoleColor.Yellow;
                //        break;
                //    case Colours.EightEight:
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        break;
                //    case Colours.NineNine:
                //        Console.ForegroundColor = ConsoleColor.DarkCyan;
                //        break;
                //    case Colours.tenTen:
                //        Console.ForegroundColor = ConsoleColor.DarkGreen;
                //        break;
                //    default:
                //        break;
                //}
                #endregion
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" |");
                Console.WriteLine();
                Console.WriteLine(" -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static List<string> PreRun()
        {
            FileStream ExportInFile = new FileStream("Exported.txt", FileMode.Open, FileAccess.Read);
            StreamReader ExportRead = new StreamReader(ExportInFile);
            List<string> Stats = new List<string>();
            string Lines = "";
            Lines = " ";
            while ((Lines = ExportRead.ReadLine()) != null)
            {
                Stats.Add(Lines);
            }
            ExportRead.Close();
            return Stats;
        }

    }
}
