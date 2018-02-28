﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTesting
{
    public partial class GetExperiment : Form
    {

        private string experimentName;


        public GetExperiment()
        {
            InitializeComponent();
        }

        public string getEnteredExperiment()
        {
            return experimentName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            experimentName = textBox1.Text;
            this.Close();
        }
    }
}