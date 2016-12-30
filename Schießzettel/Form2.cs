using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schießzettel
{
    public partial class Form2 : Form
    {
        #region Form

        public Form2()
        {
            InitializeComponent();
        }

        private Form3 _previousForm;

        public Form2(Form3 gottenPreviousForm)
        {
            InitializeComponent();
            previousForm = gottenPreviousForm;
            //http://www.mycsharp.de/wbb2/thread.php?threadid=15280
        }

        public Form3 previousForm
        {
            set { this._previousForm = value; }
            get { return this._previousForm; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            _hanldeListbox(false);
        }

        #endregion Form

        private Player player = new Player();

        private void button1_Click(object sender, EventArgs e)
        {
            //Done Button
            if (existingPl_chk.Checked)
            {
                player._loadExistingPlayer();
            }
            else
            {
                player.setNewPlayer(player_tb.Text, 0, true);
            }

            previousForm.setPlayerCount();
            previousForm.Show();
            this.Close();
        }

        private void existingPl_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (existingPl_chk.Checked)
            {
                player._loadExistingPlayer();
                _handleTextbox(false);
                _hanldeListbox(true);
                for (int i = 0; i < player.AllPlayer.Count; i++)
                {
                    listBox1.Items.Add(player.AllPlayer[i]);
                }
            }
            else
            {
                _handleTextbox(true);
                _hanldeListbox(false);
            }
        }

        private void _hanldeListbox(bool used)
        {
            if (!used)
            {
                listBox1.Enabled = false;
                listBox1.Visible = false;
            }
            else
            {
                listBox1.Enabled = true;
                listBox1.Visible = true;
            }
        }

        private void _handleTextbox(bool used)
        {
            if (!used)
            {
                player_tb.ReadOnly = true;
                player_tb.Enabled = false;
                player_tb.Text = String.Empty;
            }
            else
            {
                player_tb.ReadOnly = false;
                player_tb.Enabled = true;
                player_tb.Text = String.Empty;
            }
        }

        private string _highscore;
        private string _gamescount;

        public string Highscore
        {
            set { this._highscore = value; }
            get { return this._highscore; }
        }

        public string Gamescount
        {
            set { this._gamescount = value; }
            get { return this._gamescount; }
        }

        private void player_tb_TextChanged(object sender, EventArgs e)
        {
            if (player_tb.Text.Length >= 3)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}