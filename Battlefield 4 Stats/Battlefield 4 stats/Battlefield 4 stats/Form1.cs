using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JSONUtils;
using JSONUtilsBattlelog;
using Battle4ServerSats;

namespace Battlefield_4_stats
{
    public partial class MainForm : Form
    {

        static bool ShowPlayers = true;
        static bool UseBF4stats = true;
        string SelectedName = "";
        RootObject rootobject = new RootObject();
        RootObject2 rootobject2 = new RootObject2();
        List<RootObject3> rootObjects3 = new List<RootObject3>();
        List<string> ServerPlayerIDs = new List<string>();
        #region RankNames
        string[] RankNames = { "Recruit", "Private First Class", "Private First Class II", "Private First Class III", "Private First Class IV", "Private First Class V "
                                , "Lance Corporal", "Lance Corporal II", "Lance Corporal III", "Lance Corporal IV", "Lance Corporal V"
                                , "Corporal", "Corporal II", "Corporal III ", "Corporal IV " , "Corporal V"
                                , "Sergeant" , "Sergeant II" , "Sergeant III" , "Sergeant IV" , "Sergeant V"
                                ,"Staff Sergeant" ,"Staff Sergeant II" ,"Staff Sergeant III" ,"Staff Sergeant IV" ,"Staff Sergeant V"
                                ,"Gunnery Sergeant" ,"Gunnery Sergeant II" ,"Gunnery Sergeant III" ,"Gunnery Sergeant IV" ,"Gunnery Sergeant V"
                                ,"Master Sergeant" ,"Master Sergeant II" ,"Master Sergeant III" ,"Master Sergeant IV" ,"Master Sergeant V"
                                ,"First Sergeant" ,"First Sergeant II" ,"First Sergeant III" ,"First Sergeant IV" ,"First Sergeant V"
                                ,"Master Gunnery Sergeant" ,"Master Gunnery Sergeant II" ,"Master Gunnery Sergeant III" ,"Master Gunnery Sergeant IV" ,"Master Gunnery Sergeant V"
                                , "Sergeant Major", "Sergeant Major II", "Sergeant Major III", "Sergeant Major IV", "Sergeant Major V"
                                , "Warrant Officer One", "Warrant Officer One II", "Warrant Officer One III", "Warrant Officer One IV", "Warrant Officer One V"
                                , "Warrant Officer Two", "Warrant Officer Two II", "Warrant Officer Two III", "Warrant Officer Two IV", "Warrant Officer Two V"
                                , "Chief Warrant Officer Three", "Chief Warrant Officer Three II", "Chief Warrant Officer Three III", "Chief Warrant Officer Three IV", "Chief Warrant Officer Three V"
                                , "Chief Warrant Officer Four", "Chief Warrant Officer Four II", "Chief Warrant Officer Four III", "Chief Warrant Officer Four IV", "Chief Warrant Officer Four V"
                                , "Chief Warrant Officer Five", "Chief Warrant Officer Five II", "Chief Warrant Officer Five III", "Chief Warrant Officer Five IV", "Chief Warrant Officer Five V"
                                , "Second Lieutenant", "Second Lieutenant II", "Second Lieutenant III", "Second Lieutenant IV", "Second Lieutenant V"
                                , "First Lieutenant", "First Lieutenant II", "First Lieutenant III", "First Lieutenant IV", "First Lieutenant V"
                                , "Captain", "Captain II", "Captain III", "Captain IV", "Captain V"
                                , "Major", "Major II", "Major III", "Major IV", "Major V"
                                , "Lt. Colonel", "Lt. Colonel II", "Lt. Colonel III", "Lt. Colonel IV"
                                , "Colonel", "Colonel II", "Colonel III ", "Colonel IV ", "Colonel V"
                                , "Colonel VI", "Colonel VII", "Colonel VIII", "Colonel IX", "Colonel X"
                                , "Brigadier General", "Brigadier General II", "Brigadier General III", "Brigadier General IV", "Brigadier General V"
                                , "Brigadier General VI", "Brigadier General VII", "Brigadier General VIII", "Brigadier General IX", "Brigadier General X"
                                , "Major General"};
        #endregion

        public MainForm()
        {
            InitializeComponent();
            foreach (var Name in FileHandler.PlayerNames())
            {
                lstPlayers.Items.Add(Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelectPlayer_Click(object sender, EventArgs e)
        {
            
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlMain.SelectedIndex == 6)
            {
                txtPlayerID.Text = FileHandler.RequestedPlayerID(lstPlayers.Items[lstPlayers.SelectedIndex].ToString()).ToString();
            }
            else if (radBF4stats.Checked)
            {              
                try
                {
                    UseBF4stats = true;
                    ClearMainStatusTextBoxes();
                    tabCtrlMain.Enabled = false;
                    lstPlayers.Enabled = false;
                    SelectedName = lstPlayers.Items[lstPlayers.SelectedIndex].ToString();
                    rootobject = DownloadHandlerBF4Stats.DownloadInfo(SelectedName);
                    tabCtrlMain.Enabled = true;
                    lstPlayers.Enabled = true;
                    UpdateMainStatsBF4stats();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Problem is statistics, switching to Battlelog basic", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rootobject2 = DownloadHandlerBattlelog.DownloadInfo(SelectedName);
                    tabCtrlMain.Enabled = true;
                    lstPlayers.Enabled = true;
                    UpdateMainStatsBasicBattlelog();
                }            
            }
            else
            {
                try
                {
                    UseBF4stats = false;
                    ClearMainStatusTextBoxes();
                    tabCtrlMain.Enabled = false;
                    lstPlayers.Enabled = false;
                    SelectedName = lstPlayers.Items[lstPlayers.SelectedIndex].ToString();
                    rootobject2 = DownloadHandlerBattlelog.DownloadInfo(SelectedName);
                    rootobject = DownloadHandlerBF4Stats.DownloadInfo(SelectedName);
                    tabCtrlMain.Enabled = true;
                    lstPlayers.Enabled = true;
                    UpdateMainStatsBattlelog();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Problem is statistics, switching to Battlelog basic", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rootobject2 = DownloadHandlerBattlelog.DownloadInfo(SelectedName);
                    tabCtrlMain.Enabled = true;
                    lstPlayers.Enabled = true;
                    UpdateMainStatsBasicBattlelog();
                }                
            }            
        }

        void ClearMainStatusTextBoxes()
        {
            txtPlayerName.Text = "Downloading Stats";
            txtPlayerTag.Text = "";
            txtPlayerID.Text = "Downloading Stats";
            txtPlayerRankNr.Text = "";
            txtPlayerRankName.Text = "Downloading Stats";
            txtPlayerSkill.Text = "Downloading Stats";
            txtPlayerTimePlayed.Text = "Downloading Stats";
            txtPlayerOverallScore.Text = "Downloading Stats";
            txtPlayerKDRatio.Text = "Downloading Stats";
            txtPlayerLongestHeadshot.Text = "Downloading Stats";
            txtTopGameMode.Text = "Downloading Stats";
            txtGameModeScore.Text = "Downloading Stats";
            txtTopClass.Text = "Downloading Stats";
            txtClassScore.Text = "Downloading Stats";
            txtPlayerAccuracy.Text = "Downloading Stats";
            txtUnkownKills.Text = "Downloading Stats";
            txtPlayerURL.Text = "Downloading Stats";
        }

        void UpdateMainStatsBF4stats()
        {
            txtPlayerName.Text = rootobject.player.name;
            txtPlayerTag.Text = rootobject.player.tag;
            txtPlayerID.Text = rootobject.player.id.ToString();           
            txtPlayerRankNr.Text = rootobject.player.rank.nr.ToString();
            txtPlayerRankName.Text = rootobject.player.rank.name;
            txtPlayerSkill.Text = rootobject.stats.skill.ToString();
            var timeSpan = TimeSpan.FromSeconds(rootobject.stats.timePlayed);
            txtPlayerTimePlayed.Text = string.Format("H : {0}    M : {1}",timeSpan.Hours,timeSpan.Minutes);
            txtPlayerOverallScore.Text = string.Format("{0:n0}",rootobject.player.score);
            txtPlayerKDRatio.Text = Math.Round(rootobject.stats.extra.kdr, 2).ToString();
            txtPlayerLongestHeadshot.Text = rootobject.stats.longestHeadshot.ToString();
            string GameModeName="";
            int Score = 0;
            List<Mode> Modes = rootobject.stats.modes;
            foreach (var Mode in rootobject.stats.modes)
            {
                if (Mode.score > Score)
                {
                    Score = Mode.score;
                    GameModeName = Mode.name;
                }
            }
            txtTopGameMode.Text = GameModeName;
            txtGameModeScore.Text = Score.ToString();
            string ClassName = "";
            int? ClassScore = 0;
            foreach (var Class in rootobject.weaponCategory)
            {
                if (Class.stat.score > ClassScore)
                {
                    ClassName = Class.name;
                    ClassScore = Class.stat.score;
                }
            }
            txtTopClass.Text = ClassName;
            txtClassScore.Text = ClassScore.ToString();
            txtPlayerAccuracy.Text = Math.Round(rootobject.stats.extra.accuracy,2).ToString();
            txtUnkownKills.Text = rootobject.stats.extra.unknownKills.ToString();
            txtPlayerURL.Text = rootobject.player.blPlayer;
        }

        void UpdateMainStatsBattlelog()
        {
            txtPlayerName.Text = rootobject.player.name;
            txtPlayerTag.Text = rootobject.player.tag;
            txtPlayerID.Text = rootobject.player.id.ToString();
            txtPlayerRankNr.Text = rootobject2.data.generalStats.rank;
            txtPlayerRankName.Text = RankNames[Convert.ToInt32(rootobject2.data.generalStats.rank)];
            txtPlayerSkill.Text = rootobject2.data.generalStats.skill;
            var timeSpan = TimeSpan.FromSeconds(Convert.ToDouble(rootobject2.data.generalStats.timePlayed));
            txtPlayerTimePlayed.Text = string.Format("H : {0}    M : {1}", timeSpan.Hours, timeSpan.Minutes);
            txtPlayerOverallScore.Text = rootobject2.data.generalStats.score;
            txtPlayerKDRatio.Text = rootobject2.data.generalStats.kdRatio.ToString();
            txtPlayerLongestHeadshot.Text = rootobject2.data.generalStats.longestHeadshot.ToString();
            string GameModeName = "";
            int Score = 0;
            foreach (var Mode in rootobject.stats.modes)
            {
                if (Mode.score > Score)
                {
                    Score = Mode.score;
                    GameModeName = Mode.name;
                }
            }
            txtTopGameMode.Text = GameModeName;
            txtGameModeScore.Text = Score.ToString();
            string ClassName = "";
            int? ClassScore = 0;
            foreach (var Class in rootobject.weaponCategory)
            {
                if (Class.stat.score > ClassScore)
                {
                    ClassName = Class.name;
                    ClassScore = Class.stat.score;
                }
            }
            txtTopClass.Text = ClassName;
            txtClassScore.Text = ClassScore.ToString();
            txtPlayerAccuracy.Text = Math.Round(rootobject2.data.generalStats.accuracy,2).ToString();
            txtUnkownKills.Text = rootobject.stats.extra.unknownKills.ToString();
            txtPlayerURL.Text = rootobject.player.blPlayer;
        }

        void UpdateMainStatsBasicBattlelog()
        {
            txtPlayerName.Text = lstPlayers.Items[lstPlayers.SelectedIndex].ToString(); ;
            txtPlayerTag.Text = "N/A";
            txtPlayerID.Text = rootobject2.data.personaId.ToString();
            txtPlayerRankNr.Text = rootobject2.data.generalStats.rank;
            txtPlayerRankName.Text = RankNames[Convert.ToInt32(rootobject2.data.generalStats.rank)];
            txtPlayerSkill.Text = rootobject2.data.generalStats.skill;
            var timeSpan = TimeSpan.FromSeconds(Convert.ToDouble(rootobject2.data.generalStats.timePlayed));
            txtPlayerTimePlayed.Text = string.Format("H : {0}    M : {1}", timeSpan.Hours, timeSpan.Minutes);
            txtPlayerOverallScore.Text = rootobject2.data.generalStats.score;
            txtPlayerKDRatio.Text = rootobject2.data.generalStats.kdRatio.ToString();
            txtPlayerLongestHeadshot.Text = rootobject2.data.generalStats.longestHeadshot.ToString();
            txtTopGameMode.Text = "N/A"; ;
            txtGameModeScore.Text = "N/A"; ;
            txtTopClass.Text = "N/A"; ;
            txtClassScore.Text = "N/A"; ;
            txtPlayerAccuracy.Text = Math.Round(rootobject2.data.generalStats.accuracy, 2).ToString();
            txtUnkownKills.Text = "N/A";
            txtPlayerURL.Text = "N/A";
        }

        void UpdateDetailedStats()
        {
            txtCurrentXP.Text = rootobject.player.rank.next.curr.ToString();
            txtNeededXP.Text = rootobject.player.rank.needed.ToString();
            prgXPProgress.Maximum = rootobject.player.rank.next.curr + rootobject.player.rank.needed;
            prgXPProgress.Value = rootobject.player.rank.next.curr;
        }

        private void radBF4stats_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This API have more information but is some players' stats is outdated", "Warning");
        }

        private void radBattlelog_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This API have less information but all players' stats is updated", "Warning");
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

        }

        private void radAddPlayer_CheckedChanged(object sender, EventArgs e)
        {
            grpAddPlayer.Enabled = true;
            grpUpdatePlayerName.Enabled = false;
            grpDeleteAPlayer.Enabled = false;
        }

        private void RadUpdatePlayer_CheckedChanged(object sender, EventArgs e)
        {
            grpAddPlayer.Enabled = false;
            grpUpdatePlayerName.Enabled = true;
            grpDeleteAPlayer.Enabled = false;
        }

        private void radDeletePlayer_CheckedChanged(object sender, EventArgs e)
        {
            grpAddPlayer.Enabled = false;
            grpUpdatePlayerName.Enabled = false;
            grpDeleteAPlayer.Enabled = true;
        }

        private void tabCtrlMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabCtrlMain.SelectedIndex != 7)
            {
                lstPlayers.Show();
                lstServerPlayers.Hide();
                grpWhichAPI.Show();
            }
            else if (tabCtrlMain.SelectedIndex == 6)
            {
                grpAddPlayer.Enabled = false;
                grpUpdatePlayerName.Enabled = false;
                grpDeleteAPlayer.Enabled = false;
            }
            else if (tabCtrlMain.SelectedIndex == 2)
            {
                if (radBattlelog.Enabled == true)
                {
                    MessageBox.Show("Due to the lack of stats in Battlelog stats, you can not view this tab");
                    tabCtrlMain.SelectedIndex = 0;
                }
            }
            else if (tabCtrlMain.SelectedIndex == 1)
            {
                if (radBattlelog.Enabled == true)
                {
                    MessageBox.Show("Due to the lack of stats in Battlelog stats, you can not view this tab");
                    tabCtrlMain.SelectedIndex = 0;
                }
                if (radBF4stats.Enabled == true)
                {
                    UpdateDetailedStats();
                }
                
            }

           
            else if (tabCtrlMain.SelectedIndex == 7)
            {
                DialogResult result;
                lstServer.Items.Clear();
                lstServerPlayers.Items.Clear();
                result = MessageBox.Show("This will download all the servers' info that is saved. \nDo you which to continue or return to Main page?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    lstPlayers.Hide();
                    lstServerPlayers.Show();
                    grpWhichAPI.Hide();
                    rootObjects3 = DownloadHandlerServers.DownloadInfo();
                    foreach (var Server in rootObjects3)
                    {
                        lstServer.Items.Add(Server.message.SERVER_INFO.name);
                    }
                }
                else
                {
                    tabCtrlMain.SelectedIndex = 0;
                }
            }


        }

        private void lstServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstServerPlayers.Items.Clear();
            foreach (var Player in rootObjects3[lstServer.SelectedIndex].message.SERVER_PLAYERS)
            {
                lstServerPlayers.Items.Add(Player.persona.personaName);
                ServerPlayerIDs.Add(Player.persona.personaId);
            }
            txtServerName.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.name;
            txtServerIP.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.ip;
            txtServerCountry.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.country;
            txtServerDesc.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.extendedInfo.desc;
            txtServerPing.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.ping.ToString();
            txtServerPort.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.port.ToString();
            txtServerCurrentMap.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.map;
            txtServerSecondMap.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.maps.maps[rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.maps.nextMapIndex].map;
            foreach (var map in rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.maps.maps)
            {
                cmbMaps.Items.Add(map.map);
            }
            cmbMaps.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.map;
            if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.fairfight == 1)
            {
                chkServerFairFight.Checked = true;
            } else { chkServerFairFight.Checked = false; }
            if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.punkbuster == 1)
            {
                chkServerPunkBuster.Checked = true;
            } else { chkServerPunkBuster.Enabled = false; }
            if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.ranked == 1)
            {
                chkServerRanked.Enabled = true;
            } else { chkServerRanked.Enabled = false; }
            if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.online == 1)
            {
                chkServerOnline.Enabled = true;
            } else { chkServerOnline.Enabled = false; }
            //if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__1.current != 0)
            //{
            //    txtServerCurrentPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__1.current.ToString();
            //    txtServerMaxPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__1.max.ToString();
            //}
            //else if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__2.current != 0)
            //{
            //    txtServerCurrentPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__2.current.ToString();
            //    txtServerMaxPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__2.max.ToString();
            //}
            //else if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__4.current != 0)
            //{
            //    txtServerCurrentPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__4.current.ToString();
            //    txtServerMaxPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__4.max.ToString();
            //}
            //else if (rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__8.current != 0)
            //{
            //    txtServerCurrentPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__8.current.ToString();
            //    txtServerMaxPlayers.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_INFO.slots.__invalid_name__8.max.ToString();
            //}
            //else
            //{
            //    txtServerCurrentPlayers.Text = "0";
            //    txtServerCurrentPlayers.Text = "N/A";
            //}
            txtServerCurrentPlayers.Text = lstServerPlayers.Items.Count.ToString();
            txtServerMaxPlayers.Text = "WIP";
        }

        private void lstServerPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            RootObject2 rootobjectServer = DownloadHandlerBattlelog.DownloadServerPlayerInfo(rootObjects3[lstServer.SelectedIndex].message.SERVER_PLAYERS[lstServerPlayers.SelectedIndex].personaId);
            txtPlayerID.Text = ServerPlayerIDs[lstServerPlayers.SelectedIndex];
            txtServerPlayerName.Text = rootObjects3[lstServer.SelectedIndex].message.SERVER_PLAYERS[lstServerPlayers.SelectedIndex].persona.personaName;
            txtServerPlayerRankNr.Text = rootobjectServer.data.generalStats.rank;
            if (Convert.ToInt32(rootobjectServer.data.generalStats.rank) > 120)
            {
                txtServerPlayerRankName.Text = RankNames[120];
            }
            else
            {
                txtServerPlayerRankName.Text = RankNames[Convert.ToInt32(rootobjectServer.data.generalStats.rank)];
            }
            
            txtServerPlayerSkill.Text = rootobjectServer.data.generalStats.skill;
            //var timeSpan = TimeSpan.FromSeconds(Convert.ToDouble(rootobject2.data.generalStats.timePlayed));
            //txtServerPlayerTimePlayed.Text = string.Format("H : {0}    M : {1}", timeSpan.Hours, timeSpan.Minutes);
            txtServerPlayerTimePlayed.Text = "WIP";
            txtServerPlayerScore.Text = string.Format("{0:n0}", rootobjectServer.data.generalStats.score);
            txtServerPlayerLongestHeadshot.Text = rootobjectServer.data.generalStats.longestHeadshot.ToString();
            txtServerPlayerKDRatio.Text = Math.Round(rootobjectServer.data.generalStats.kdRatio,2).ToString();
            txtServerPlayerAccuracy.Text = Math.Round(rootobjectServer.data.generalStats.accuracy,2).ToString();
            picPrfile.ImageLocation = "http://www.gravatar.com/avatar/" + rootObjects3[lstServer.SelectedIndex].message.SERVER_PLAYERS[lstServerPlayers.SelectedIndex].persona.user.gravatarMd5;

        }
    }
}
