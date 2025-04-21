using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;
using Bombones2025.Servicios;

class Program
{
    static FrutosServicios frutoServicio = new FrutosServicios("frutos_secos.txt");
    static PaisRepositorio paisRepositorio = new PaisRepositorio("paises.txt");

    static void Main()
    {
        Console.WriteLine("El programa ha iniciado correctamente.");
        Console.ReadLine();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("-- Menú de la Fábrica de Bombones --");
            Console.WriteLine("1. Listar Países");
            Console.WriteLine("2. Listar Frutos Secos");
            Console.WriteLine("3. Agregar Fruto Seco");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    ListarPaises();
                    break;
                case "2":
                    ListarFrutosSecos();
                    break;
                case "3":
                    AgregarFrutoSeco();
                    break;
                
                case "5":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Presione Enter para continuar...");
                    Console.ReadLine();
                    break;
            }
        }

        static void ListarPaises()
        {
            Console.WriteLine("Lista de Países");
            var paises = paisRepositorio.GetPaises();
            if (paises.Count == 0)
            {
                Console.WriteLine("No hay países registrados.");
            }
            else
            {
                foreach (var pais in paises)
                {
                    Console.WriteLine(pais);
                }
            }
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        
            static void ListarFrutosSecos()
            {
                Console.WriteLine("Lista de Frutos Secos");
                var frutos = frutoServicio.ListarFrutosSecos();

                if (frutos == null || frutos.Count == 0)
                {
                    Console.WriteLine("No hay frutos secos registrados.");
                }
                else
                {
                    foreach (var fruto in frutos)
                    {
                        Console.WriteLine($"{fruto.IdFruto} - {fruto.NombreFruto} ");
                    }
                }
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
            }

        static void AgregarFrutoSeco()
        {
            Console.Write("Ingrese el ID: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el nombre del fruto seco: ");
            string nombre = Console.ReadLine()!;
        

            FrutosSecos nuevoFruto = new FrutosSecos
            {
                IdFruto = id,
                NombreFruto = nombre,
               
            };

            frutoServicio.AgregarFrutoSeco(nuevoFruto);
            Console.WriteLine("Fruto Seco agregado correctamente.");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();

        }
      
    }
}