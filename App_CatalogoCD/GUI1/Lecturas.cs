﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_CatalogoCD
{
    public partial class Lecturas : Form
    {
        public Lecturas()
        {
            InitializeComponent();
        }
        public void llenarTextBox(string dat)
        {
            txbResultado.Text = dat;
        }
    }
}
