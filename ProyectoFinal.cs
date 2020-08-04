using System;

namespace ProyectoF
{
  
    class Program
    {
        static string Roles()
        {
            string rol = "";
            Random aleatorio = new Random();
            int aleatory = aleatorio.Next(1, 4);

            if (aleatory == 1)
            {
                rol = "Administrador";
            }
            if (aleatory == 2)
            {
                rol = "Supervisor";
            }
            if (aleatory == 3)
            {
                rol = "Vendedor";
            }
            return rol;
        }
        static string Estados()
        {

            int a;
            Random Status = new Random();
            a = Status.Next(1, 5);
            string estado = "";

            if (a == 1 || a == 2 )
            {
                estado = "Activo";
            }
            if (a == 3|| a == 4)
            {
                estado = "Inactivo";
                
            }
            return estado;
        }
        static void Main(string[] args)
        {
            DateTime[] creacion = new DateTime[3];
            long Devuelta;
            string[] name = new string[3];
            string[] usuario = new string[3];
            long[] contrasena = new long[3];

            Console.WriteLine("-------CREAR USUARIO---------");
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Escribir nombre: ");
                name[i] = Console.ReadLine(); 

                Console.Write("Digite la cedula como No.Usuario: ");
                usuario[i] = Console.ReadLine();

                if (long.TryParse(usuario[i], out Devuelta) == false || usuario[i].Length != 11)
                {
                    do
                    {
                        Console.WriteLine("El usuario debe ser de 11 digitos");
                        Console.Write("\nDigite la cedula como No.Usuario: ");
                        usuario[i] = Console.ReadLine();

                    } while(usuario[i].Length != 11);
                }
               
                Console.Write("Escribe una contraseña: ");
                contrasena[i] = Convert.ToInt64(Console.ReadLine());
                creacion[i] = DateTime.Now;
               
                Console.WriteLine();
                Console.WriteLine("Usuario registrado correctamente!");
                Console.WriteLine("Fecha de creacion del usuario: {0}", creacion[i]);
                Console.WriteLine();
            }
            string user;
            int u = 0;
            long password;
            int p = 0;
            string n = "";

            Console.WriteLine("-----INICIAR SESION-----");
            Console.WriteLine();
            do
            {
                Console.Write("Usuario: ");
                user = Console.ReadLine();

                Console.Write("Contrasena: ");
                password = Convert.ToInt64(Console.ReadLine());

                if (usuario[0] == user && contrasena[0] == password)
                {
                     u = 0;
                    p = 0;
                    n = name[0];
                }
                else if (usuario[1] == user && contrasena[1] == password)
                {
                     u = 1;
                    p = 1;
                     n= name[1];
                }
                else if (usuario[2] == user && contrasena[2] == password)
                {
                     u = 2;
                    p = 2;
                    n = name[2];
                }
                else
                {
                    Console.WriteLine("\nEl usuario o la contraseña es incorrecta, Intentelo denuevo.");
                }
            } while (usuario[u] != user || contrasena[p] != password);

            if(Estados() == "Activo")
            {
                Console.WriteLine("\nBienvenido/a {0}. haz entrado con el usuario {1} y su rol es {2}.", n, usuario[u], Roles());
            }
            else
            {
                while (Estados() == "Inactivo")
                {   
                    Console.WriteLine("\nEl usuario se encuentra inactivo, Ingrese otro usuario o Intentelo mas tarde ");

                    do
                    {
                        Console.Write("\nUsuario: ");
                        user = Console.ReadLine();

                        Console.Write("Contrasena: ");
                        password = Convert.ToInt64(Console.ReadLine());

                        if (usuario[0] == user && contrasena[0] == password)
                        {
                            u = 0;
                            p = 0;
                            n = name[0];
                        }
                        else if (usuario[1] == user && contrasena[1] == password)
                        {
                          
                            u = 1;
                            p = 1;
                            n = name[1];
                        }
                        else if (usuario[2] == user && contrasena[2] == password)
                        {
                            u = 2;
                            p = 2;
                            n = name[2];
                        }
                        else
                        {
                            Console.WriteLine("El usuario o la contraseña es incorrecta, Intentelo denuevo.");
                            Console.WriteLine();
                        }
                    } while (usuario[u] != user || contrasena[p] != password);
                 
                } 
                Console.WriteLine("\nBienvenido/a {0}. haz entrado con el usuario {1} y su rol es {2}.", n, usuario[u],Roles());
            }

        }
    }
}
