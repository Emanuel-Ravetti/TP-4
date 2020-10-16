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
        public int Total = 0;

        public RngPedido[] ListaPedido = new RngPedido[5];
        private int indice = 0;
        #endregion

        #region CONSTRUCTOR
        public Pedido()
        {
            Fecha = DateTime.Now;
            //todo: hacer contadod numero pedido con xml
        }
        #endregion

        #region METODOS
        public void AddRngPedido(RngPedido renglon)
        {
            ListaPedido[indice] = renglon;
            indice = indice + 1;
        }
       
        public string MuestraPedidos()
        {
            String Lineas = "";
            for (int i = 0; i < indice; i++)
            {
                Lineas = Lineas + ListaPedido[i].MuestraPedido();
            }
            return Lineas;
        }
        #endregion

    }
}
