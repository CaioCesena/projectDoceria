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

namespace Doceria
{   
    public partial class Servicos : Form
    {
        Thread t3;
        public Servicos()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(FormInicial);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }
        private void FormInicial(object obj)
        {
            Application.Run(new FormInicial());
        }
    }
}
