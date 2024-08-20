using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMEpec.Negocio
{
    public class Contrato	
    {
		private int numero;
		private string cliente;
		private int tarifa;
		private string tipo;
		private DateTime fechaInicio;

		public DateTime FechaInicio
		{
			get { return fechaInicio; }
			set { fechaInicio = value; }
		}

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		public int Tarifa
		{
			get { return tarifa; }
			set { tarifa = value; }
		}

		public string Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

	}
}
