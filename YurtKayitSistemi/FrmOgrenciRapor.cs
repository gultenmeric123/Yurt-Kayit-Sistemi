﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
	public partial class FrmOgrenciRapor : Form
	{
		public FrmOgrenciRapor()
		{
			InitializeComponent();
		}

		private void FrmOgrenciRapor_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
