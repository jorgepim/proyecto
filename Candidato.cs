using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.CLases
{
    internal class Candidato : Persona
    {
        //Variables
        private string partido;
        private int votos;
        private decimal inversion;
        public string memelin;
        //Setters and Getters
        public string Partido
        {
            get { return partido; }
            set { partido = value; }
        }
        public int Votos
        {
            get { return votos; }
            set { votos = value; }
        }
        public decimal Inversion
        {
            get { return inversion; }
            set { inversion = value; }
        }
        //Constructor
        public Candidato(string partido, int votos, decimal inversion, string nombre, int edad, string dui, string direccion, string tel) : base(nombre, edad, dui, direccion, tel)
        {
            Partido = partido;
            Votos = votos;
            Inversion = inversion;
        }
    }
}
