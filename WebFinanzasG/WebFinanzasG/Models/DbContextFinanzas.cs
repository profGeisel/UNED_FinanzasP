using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinanzasG.Models
{
	//clase para la administracion de la conexion con la BD
	public class DbContextFinanzas : DbContext
	{
		//Establecer cadena de conexion 
		public DbContextFinanzas() : base("name=DefaultConnection") { }
		//tablas para llamado bd
		public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}