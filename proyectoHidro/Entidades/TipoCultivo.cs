using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoHidro.Entidades
{
    public class TipoCultivo
    {
        private int codigo;
        private string tipo;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }

        public TipoCultivo() { }
        public TipoCultivo(int cod, string tipo)
        {
            this.codigo = cod;
            this.tipo = tipo;
        }
    }
}
