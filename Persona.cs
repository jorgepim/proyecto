using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.CLases
{
    internal class Persona
    {
        //Variahles
        protected string nombre, dui, direccion, tel;
        protected int edad;
        //Setters and Getters
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        //Constructor
        public Persona(string nombre, int edad, string dui, string direccion, string tel)
        {
            Nombre = nombre;
            Dui = dui;
            Direccion = direccion;
            Tel = tel;
            Edad = edad;
        }
    }
}
