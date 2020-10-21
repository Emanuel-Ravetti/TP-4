using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BA
{
    public class Contador
    {
        #region PROPIEDADES
        DataTable cliente = new DataTable();

        #endregion

        #region CONSTRUCTOR
        public Contador()
        {
            cliente.TableName = "NumeroCliente";
            cliente.Columns.Add("lista", typeof(int));
            if (!System.IO.File.Exists(@"cliente.xml"))
            {
                cliente.Rows.Add();
                cliente.Rows[0][0] = 0;
                cliente.WriteXml(@"cliente.xml");
            }
            cliente.ReadXml(@"cliente.xml");
        }

        #endregion

        #region METODOS
        public int ContadorCliente()
        {
            int numero = (int)cliente.Rows[0][0] + 1;
            cliente.Rows[0][0] = numero;
            cliente.WriteXml(@"cliente.xml");
            return numero;
        }

        #endregion
    }
}
