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
        public bool Coca = false;
        public bool Fanta = false;
        public bool Sprite = false;
        public bool Agua = false;
        public int Bebida = 0;
        #endregion

        #region CONSTRUCTOR

        #endregion

        #region METODOS
        public int Total()
        {
            return Hamburguesa + Bebida;
        }

        public String MuestraPedido()
        {
            String Linea = "";

            if (Hamburguesa == 160)
            {
                Linea = "Hamburguesa Simple  |  ";
            }
            else if (Hamburguesa == 190)
            {
                Linea = "Hamburguesa Doble  |  ";
            }
            else if (Hamburguesa == 220)
            {
                Linea = "Hamburguesa Triple  |  ";
            }

            if (Lechuga == true)
            {
                Linea = Linea + "Lechuga | ";
            }
            if (Tomate == true)
            {
                Linea = Linea + "Tomate | ";
            }
            if (Bacon == true)
            {
                Linea = Linea + "Bacon | ";
            }
            if (Salsa == true)
            {
                Linea = Linea + "Salsa | ";
            }
            if (Pepinillos == true)
            {
                Linea = Linea + "Pepinillos | ";
            }

            if (Coca == true)
            {
                Linea = Linea + "Coca |\r \n";
            }
            else if (Fanta == true)
            {
                Linea = Linea + "Fanta |\r \n";
            }
            else if (Sprite == true)
            {
                Linea = Linea + "Sprite |\r \n";
            }
            else if (Agua == true)
            {
                Linea = Linea + "Agua |\r \n";
            }

            return Linea;

        }
        #endregion
    }
}