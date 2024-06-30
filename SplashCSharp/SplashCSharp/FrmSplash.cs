﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashCSharp
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Shown(object sender, EventArgs e)
        {
            lblStatus.Text = "Carregando o sistema...";
            this.Refresh();
            for(int i = 1; i < 501; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(10);
            }
            progressBar1.Value = 499;
            Thread.Sleep(200);
            this.Close();
        }
    }
}
