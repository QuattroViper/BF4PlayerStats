using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Battlefield_4_stats
{
    class FileHandler
    {

        static FileStream fileStream;
        static StreamReader Reader;

        static public List<string> PlayerIDs()
        {
            List<string> Names = new List<string>();
            try
            {
                if (!File.Exists("Players.txt"))
                {
                    throw new FileNotFoundException("Players.txt is not found");
                }
                else
                {
                    fileStream = new FileStream("Players.txt", FileMode.Open, FileAccess.Read);
                    Reader = new StreamReader(fileStream);
                    string line;
                    while ((line = Reader.ReadLine()) != null)
                    {
                        Names.Add(line);
                    }
                }

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                fileStream.Close();
            }

            return Names;

        }

        static public List<string> PlayerNames()
        {

            List<string> Names = new List<string>();
            try
            {
                if (!File.Exists("Players.txt"))
                {
                    throw new FileNotFoundException("Players.txt is not found");
                }
                else
                {
                    fileStream = new FileStream("Players.txt", FileMode.Open, FileAccess.Read);
                    Reader = new StreamReader(fileStream);
                    string line;
                    while ((line = Reader.ReadLine()) != null)
                    {
                        string[] Splitted = line.Split(',');
                        Names.Add(Splitted[0]);
                    }
                }

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            finally
            {
                fileStream.Close();
            }

            return Names;

        }

        static public int RequestedPlayerID(string Name)
        {
            int PlayerID = 0;
            try
            {
                if (!File.Exists("Players.txt"))
                {
                    throw new FileNotFoundException("Players.txt is not found");
                }
                else
                {
                    fileStream = new FileStream("Players.txt", FileMode.Open, FileAccess.Read);
                    Reader = new StreamReader(fileStream);
                    string line;
                    while ((line = Reader.ReadLine()) != null)
                    {
                        string[] Splitted = line.Split(',');
                        if (Splitted[0] == Name)
                        {
                            PlayerID = int.Parse(Splitted[1]);
                        }
                    }
                }

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                fileStream.Close();
            }
            return PlayerID;
        }

        static public List<string> ServerGUID()
        {
            List<string> ServerGUID = new List<string>();
            try
            {
                if (!File.Exists("Servers.txt"))
                {
                    throw new FileNotFoundException("Servers.txt is not found");
                }
                else
                {
                    fileStream = new FileStream("Servers.txt", FileMode.Open, FileAccess.Read);
                    Reader = new StreamReader(fileStream);
                    string line;
                    while ((line = Reader.ReadLine()) != null)
                    {
                        ServerGUID.Add(line);
                    }
                }

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                fileStream.Close();
            }
            return ServerGUID;
        }
    }
}
