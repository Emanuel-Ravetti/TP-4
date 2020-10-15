using System;
using System.Collections.Generic;
using System.Text;

namespace BA
{
    public class RngPedido
    {
        #region PROPIEDADES
        public int Hamburguesa = 0;
        public bool Lechuga = false;
        public bool Tomate = false;
        public bool Bacon = false;
        public bool Salsa = false;
        public bool Pepinillos = false;
        public int Bebida = 0;

        #endregion

        #region CONSTRUCTOR
        
        #endregion

        #region METODOS
        public int Total()
        {
            return Hamburguesa + Bebida;
        }
        #endregion
    }
}
