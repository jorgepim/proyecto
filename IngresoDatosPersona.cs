using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.CLases;

namespace Proyecto
{
    public partial class IngresoDatos : Form
    {
        private Dictionary<string, Persona> _datosPersona;
        public IngresoDatos()
        {
            InitializeComponent();
        }
    }
}
