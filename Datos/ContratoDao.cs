using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMEpec.Datos
{
    internal class ContratoDao
    {
        AccesoDatos oBD;

        public ContratoDao()
        {
            oBD = new AccesoDatos();
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            return oBD.ConsultarTabla(nombreTabla);
        }

        public int ActualizarBD(string consultaSQL, List<Parametro> lParametros)
        {
            return oBD.ActualizarBD(consultaSQL, lParametros);
        }

    }
}
