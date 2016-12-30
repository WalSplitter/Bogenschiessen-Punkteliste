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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            selectedPlayerCount = 0;
        }

        private int _selectedPlayerCount;

        public int selectedPlayerCount
        {
            set { this._selectedPlayerCount = value; }
            get { return this._selectedPlayerCount; }
        }

        public void setPlayerCount()
        {
            selectedPlayerCount += 1;
            textBox1.Text = selectedPlayerCount.ToString();
        }

        #region Select Player

        private void select_btn_Click(object sender, EventArgs e)
        {
            Form2 Player1 = new Form2(this);
            this.Hide();
            Player1.Show();
        }

        private void select2_btn_Click(object sender, EventArgs e)
        {
            Form2 Player2 = new Form2(this);
            this.Hide();
            Player2.Show();
        }

        private void select3_btn_Click(object sender, EventArgs e)
        {
            Form2 Player3 = new Form2(this);
            this.Hide();
            Player3.Show();
        }

        private void select4_btn_Click(object sender, EventArgs e)
        {
            Form2 Player4 = new Form2(this);
            this.Hide();
            Player4.Show();
        }

        private void select5_btn_Click(object sender, EventArgs e)
        {
            Form2 Player5 = new Form2(this);
            this.Hide();
            Player5.Show();
        }

        #endregion Select Player

        private void next_btn_Click(object sender, EventArgs e)
        {
            //Next Button
            Form4 SetRoundsForm = new Form4();
            this.Hide();
            SetRoundsForm.Show();
        }

        private void count_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            _disableButtons();
            textBox1.Text = selectedPlayerCount.ToString();
            next_btn.Enabled = false;
        }

        private void _disableButtons()
        {
            select_btn.Enabled = false;
            select2_btn.Enabled = false;
            select3_btn.Enabled = false;
            select4_btn.Enabled = false;
            select5_btn.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(this.listBox1.SelectedItem.ToString()))
            {
                case 1:
                    _disableButtons();
                    select_btn.Enabled = true;
                    break;

                case 2:
                    _disableButtons();
                    select_btn.Enabled = true;
                    select2_btn.Enabled = true;
                    break;

                case 3:
                    _disableButtons();
                    select_btn.Enabled = true;
                    select2_btn.Enabled = true;
                    select3_btn.Enabled = true;
                    break;

                case 4:
                    _disableButtons();
                    select_btn.Enabled = true;
                    select2_btn.Enabled = true;
                    select3_btn.Enabled = true;
                    select4_btn.Enabled = true;
                    break;

                case 5:
                    _disableButtons();
                    select_btn.Enabled = true;
                    select2_btn.Enabled = true;
                    select3_btn.Enabled = true;
                    select4_btn.Enabled = true;
                    select5_btn.Enabled = true;
                    break;

                default:
                    _disableButtons();
                    break;
            }
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            //Nachschaun ob schon Spieler ausgewählt wurden
            MessageBox.Show("test");
        }
    }
}