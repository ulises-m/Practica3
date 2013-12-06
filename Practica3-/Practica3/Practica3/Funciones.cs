	using System;
	using System.Collections;
	using System.Threading;

	namespace Practica3
	{
		public class usuario
		{
			public Hashtable Tabla;

			public usuario()
			{
				this.Tabla = new Hashtable();
			}
			 
			public void Ingresar()
			{
				for (int i=0; i<4; i++) 
				{
					Persona P = new Persona ();

					Console.Write("Codigo:");
					P.Cod = int .Parse( Console.ReadLine());

					Console.Write ("Nombre:");
					P.Nombre = Console.ReadLine();

					Console.Write ("Teléfono:");
					P.Telefono = Console.ReadLine();
					 
					Console.Write ("Facebook:");
					P.Facebook = Console.ReadLine();

					Tabla.Add(P.Cod,P);

					Console.Clear ();
				}

			}

			public void Editar()
			{
				for (int i=0; i<2; i++) 
				{
					Console.WriteLine("Ingrese el codigo a editar:");
					int cod = int.Parse (Console.ReadLine ());
					if (Tabla.ContainsKey (cod))
					{
									
						Persona capturar = (Persona)(Tabla[cod]);
						
						Console.Write("Codigo:\n");
						Console.WriteLine(capturar.Cod);

						Console.Write("Nombre:");
						Console.WriteLine(capturar.Nombre);

						Console.Write("Telefono:");
						Console.WriteLine(capturar.Telefono);

						Console.Write("Facebook");
						Console.WriteLine(capturar.Facebook);


						Console.WriteLine ();
						Console.WriteLine("capturar");

						Console.Write ("Nombre:");
						capturar.Nombre = Console.ReadLine();

						Console.Write ("Telefono:");
						capturar.Telefono = Console.ReadLine();

						Console.Write ("Facebook:");
						capturar.Facebook = Console.ReadLine();
					}
					else
					{
						Console.WriteLine("No  existe el codigo");
					         Console.Write ("Continuar");
					}
					
					Console.Clear ();
				}

			
			}
			public void Eliminar()
			{
				for (int i=0; i<2; i++) 
				{
					Console.Write("Ingrese el codigo  a Eliminar:");
					int cod = int.Parse (Console.ReadLine ());
					if (Tabla.ContainsKey (cod) == true) {
						Persona Eliminacion = new Persona();
						Eliminacion = (Persona)(Tabla [cod]);

						Console.Write ("Codigo:");
						Console.WriteLine (Eliminacion.Cod);

						Console.Write ("Nombre:");
						Console.WriteLine (Eliminacion.Nombre);

						Console.Write ("Telefono:");
						Console.WriteLine (Eliminacion.Telefono);

						Console.Write ("Facebook:");
						Console.WriteLine (Eliminacion.Facebook);

						Console.Write ("¿Esta seguro de sea eliminar? si) 1 no) 0: ");
						int opc = int.Parse (Console.ReadLine ());
						if (opc == 1) 
						{
							Tabla.Remove (cod);
							Console.Write ("Se elimino la persona");
							
							Console.Clear ();
						}
		
					} 
					else 
					{
						Console.WriteLine("No existe el codigo");
						Console.WriteLine("Precione ENTER  para CONTINUAR");
						
						Console.Clear();
					}
				}
					
			}
			
			
			public void Mostrar()
			{
				
				Console.WriteLine("usuarios registrados:");
				Console.WriteLine();
				IDictionaryEnumerator enumerador = Tabla.GetEnumerator();
			    while ( enumerador.MoveNext() )
				{
					Persona imprimir = (Persona)(Tabla[enumerador.Key]);
					Console.Write ("Codigo:");
					Console.WriteLine (imprimir.Cod);

					Console.Write ("Nombre:");
					Console.WriteLine (imprimir.Nombre);

					Console.Write ("Telefono:");
					Console.WriteLine (imprimir.Telefono);

					Console.Write ("Facebook:");
					Console.WriteLine (imprimir.Facebook);
					Console.WriteLine();

				}
			}
		}
	}

