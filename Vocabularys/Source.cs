﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabularys
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://onedrive.live.com/?authkey=%21ANIEbAUKHJG5crY&id=64E22A4EBDC4FC65%2123199&cid=64E22A4EBDC4FC65");

        }
    }
}