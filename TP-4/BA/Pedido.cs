using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BA
{
    public class Pedido
    {
        #region PROPIEDADES
        public DateTime Fecha;
        public int NumeroCliente = 0;
        public int Total = 0;

        public RngPedido[] ListaPedido = new RngPedido[5];
        private int indice = 0;

        //DataTable numeroCliente = new DataTable();

        public bool flag = false;
        #endregion

        #region CONSTRUCTOR
        public Pedido()
        {
            Fecha = DateTime.Now;
            //todo: numeroCliente.TableName = "";
            //numeroCliente.Columns.Add("", typeof(int));
            //numeroCliente.Rows.Add();
            //numeroCliente.Rows[0][0] = numeroCliente.ReadXml(@"NumeroCliente.xml");
            flag = false;
        }
        #endregion

        #region METODOS
        public void AddRngPedido(RngPedido renglon)
        {
            ListaPedido[indice] = renglon;
            indice = indice + 1;
            CalcularTotal();
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

        public void CalcularTotal()
        {
            int SumaTotal = 0;
            for (int i = 0; i < indice; i++)
            {
                SumaTotal = SumaTotal + ListaPedido[i].Total();
            }

            Total = SumaTotal;
        }

        public void ReiniciarPedido()
        {
            indice = 0;
            for (int i = 0; i < indice; i++)
            {
                ListaPedido[i] = null;
                indice = indice + 1;
            }
            indice = 0;
            Total = 0;
            flag = false;
        }
        #endregion

    }
}
