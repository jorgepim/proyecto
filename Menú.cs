﻿using Proyecto.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EleccionDeRegistro abrir = new EleccionDeRegistro();
            this.Close();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificadorDeVoto abrir = new VerificadorDeVoto();
            this.Close();
            abrir.Show();
        }
    }
}
