﻿using SysPronatec.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPronatec
{
    public partial class SysPronatec : Form
    {
        public SysPronatec()
        {
            InitializeComponent();
        }

        private void novoCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadCandidato().ShowDialog();
        }
    }
}
