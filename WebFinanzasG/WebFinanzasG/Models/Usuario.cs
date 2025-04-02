using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanzasG.Models
{
	public class Usuario
	{
		public int Id { get; set; }
		public string N_Usuario { get; set; }
		public string Contraseña { get; set; }
		public string nomUsuario { get; set; }
		public string Ap1Usuario { get; set; }
		public string Ap2Usuario { get; set; }
		public string CorreoElectronico { get; set; }
	}
}