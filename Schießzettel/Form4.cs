﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Form3 gottenPreviousForm)
        {
            previousForm = gottenPreviousForm;
        }

        private Form3 _previousForm;

        public Form3 previousForm
        {
            set { this._previousForm = value; }
            get { return this._previousForm; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Play Button
            Form5 game = new Form5();
            this.Hide();
            game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Back Button
            this.Hide();
            previousForm.Show();
        }
    }
}