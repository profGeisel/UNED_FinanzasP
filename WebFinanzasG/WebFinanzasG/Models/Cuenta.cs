using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanzasG.Models
{
	public class Cuenta
	{
		public int Id { get; set; }
		public string NumCuenta { get; set; }
		public double saldo		{ get; set; }
		public int IdProveedor { get; set; }
		public int IdMoneda { get; set; }
		public Boolean Activa { get; set; }
		public int IdUsuario { get; set; }
	}
}