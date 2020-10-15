using System;
using System.Collections.Generic;
using System.Text;

namespace BA
{
    public class Pedido
    {
        #region PROPIEDADES
        public DateTime Fecha;
        public string NumeroPedido = "";
        //public ListaPedido
        public int Total = 0;
        #endregion

        #region CONSTRUCTOR
        public Pedido()
        {
            Fecha = DateTime.Now;
            //todo: hacer contadod numero pedido con xml
        }
        #endregion

        #region METODOS
       
        #endregion

    }
}
