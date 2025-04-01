using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanzasG.Models
{
	public class Registro
	{
		public int Id { get; set; }
		public string Fecha { get; set; }
		public string Descripcion { get; set; }
		public int Comprobante { get; set; }
		public double Monto		{ get; set; }
		public int IdCategoria { get; set; }
		public int IdCuenta { get; set; }
	}
}