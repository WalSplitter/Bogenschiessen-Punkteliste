using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schießzettel
{
    internal class Player
    {
        private string _playername;
        private int _highscore;
        private int _playscore;
        private bool _used;

        #region Getter Setter

        public string playername
        {
            get { return this._playername; }
            set { this._playername = value; }
        }

        public int highscore
        {
            get { return this._highscore; }
            set { this._highscore = value; }
        }

        public int playscore
        {
            get { return this._playscore; }
            set { this._playscore = value; }
        }

        public bool used
        {
            get { return this._used; }
            set { this._used = value; }
        }

        #endregion Getter Setter

        public void _loadExistingPlayer()
        {
            AllPlayer.Clear();
            _streamRead();
        }

        public void setNewPlayer(string p1, int s1, bool u1)
        {
            _streamWriter(p1, 0, s1, u1);
        }

        private void setDefault()
        {
            playername = "Player1";
            highscore = 0;
            playscore = 0;
            used = false;
        }

        private void _streamWriter(string Playername, int Highscore, int Playscore, bool Used)
        {
            string player = Playername;
            string highscore = Highscore.ToString();
            string playscore = Playscore.ToString();
            string used = Used.ToString();
            string path = Application.StartupPath + "\\Players.txt";

            if (!File.Exists(path))
            {
                StreamWriter writer = File.CreateText(path);
                writer.WriteLine("{0};{1};{2};{3}", player, highscore, playscore, used);
                writer.Close(); // Den Dateizugriff beenden
                string[] item = { player, highscore, playscore, used };
                //AllPlayer.AddRange(item);
                _streamRead();
            }
            else
            {
                _streamReadWrite();
                bool existingPlayer = _findExistingPlayer(Playername);

                if (!existingPlayer)
                {
                    StreamWriter writer = File.CreateText(path);
                    writer.WriteLine("{0};{1};{2};{3}", player, highscore, playscore, used);
                    writer.Close(); // Den Dateizugriff beenden
                    string[] item = { player, highscore, playscore, used };
                    //AllPlayer.AddRange(item);
                    _streamRead();
                }
                else
                {
                    MessageBox.Show("This Player exists already!\n Choose a new one...");
                }
            }
        }

        private void _streamReadWrite()
        {
            string path = Application.StartupPath + "\\Players.txt";
            string[] zeile;
            setDefault();

            StreamReader reader = File.OpenText(path);
            for (int i = 0; -1 != reader.Peek(); i++)
            {
                zeile = reader.ReadLine().Split(';');
                playername = zeile[0];
                highscore = Convert.ToInt32(zeile[1]);
                playscore = Convert.ToInt32(zeile[2]);
                used = Convert.ToBoolean(zeile[3]);
            }
            reader.Close();
        }

        private bool _findExistingPlayer(string Playername)
        {
            if (AllPlayer.Count == 0)
            {
                return false;
            }

            foreach (var item in AllPlayer)
            {
                if (item == Playername)
                {
                    return true;
                }
            }
            return false;
        }

        private void _streamRead()
        {
            string path = Application.StartupPath + "\\Players.txt";

            string[] zeile;

            setDefault();

            StreamReader reader = File.OpenText(path);
            for (int i = 0; -1 != reader.Peek(); i++)
            {
                zeile = reader.ReadLine().Split(';');
                //AllPlayer.AddRange(zeile);
                AllPlayer.Add(zeile[0]);

                playername = zeile[0];

                highscore = Convert.ToInt32(zeile[1]);

                playscore = Convert.ToInt32(zeile[2]);

                used = Convert.ToBoolean(zeile[3]);
            }
            reader.Close();
        }

        private List<string> _allPlayer = new List<string>();

        public List<string> AllPlayer
        {
            get { return _allPlayer; }
            set { _allPlayer = value; }
        }
    }
}