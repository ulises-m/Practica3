using System;

namespace Practica3
{
	class Programa
	{
		public static void Main (string[] args)
		{
			usuario u = new usuario();
			u.Ingresar ();
			  Console.Clear();
			u.Editar ();
			  Console.Clear();
			u.Eliminar ();
			  Console.Clear();
			u.Mostrar();
			Console.ReadKey();
			  Console.Clear();
		}
	}
}
