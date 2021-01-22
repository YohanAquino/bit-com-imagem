using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitABit
{
    class Lampada
    {
        private byte estado;
        public Lampada()
        {
            this.estado = 0;
        }

        public Lampada(byte estado)
        {
            this.estado = estado;
        }
        public void acender(int lampada)
        {
            int valor;
            valor = (int)Math.Pow(2, lampada - 1);
            this.estado = (byte)((int)estado | valor);
        }

        public void apagar(int lampada)
        {
            int valor;
            valor = 255 - (int)Math.Pow(2, lampada - 1);
            this.estado = (byte)((int)estado & valor);
        }

        public byte getEstado()
        {
            return this.estado;
        }

        public bool getEstado(int lampada)
        {
            int valor,resultado;
            valor = (int)Math.Pow(2, lampada - 1);
            resultado = (byte)((int)estado & valor);
            return (resultado > 0);
        }
    }
}
