using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Duran;
internal class Program
{
    public List<Provincia> provincias = new();

    public static string nombresucio { get; set; }
    public static void Main(string[] args)
    {
        {
            Provincia p = new Provincia();
            CargarProvincia(p);
            Console.WriteLine(p.Nombre + p.Gobernador + p.Region);
            foreach (Ciudad ciudad in p.ciudades)
            {
                Console.WriteLine(ciudad.CantHabitantes + ciudad.Nombre + ciudad.Superficie);
            }
            Console.ReadKey();
        }
    }
    public static Provincia CargarProvincia(Provincia provincia)
    {
        Ciudad c = new Ciudad();
        Provincia nuevaprovincia;
        Console.WriteLine("Ingrese el nombre de la provincia");
        provincia.Nombre = Console.ReadLine();
        if (!string.IsNullOrEmpty(provincia.Nombre))
        {
            Console.WriteLine("Ingrese el nombre del gobernador");
            provincia.Gobernador = Console.ReadLine();
            Console.WriteLine("Ingrese la region");
            provincia.Region = Console.ReadLine();
            do
            { 
                CargarCiudad(c);
                provincia.CargarCiudades(c);
            }while(!string.IsNullOrEmpty(nombresucio));
            nuevaprovincia = provincia;
            return nuevaprovincia;
        }
        else
        {
            return null;
        }
    }
    public static Ciudad CargarCiudad(Ciudad ciudad)
    {
        Console.WriteLine("Ingrese el nombre de la ciudad");
        nombresucio = Console.ReadLine();
        if (!string.IsNullOrEmpty(nombresucio))
        {
            ciudad.Nombre = nombresucio;
            Console.WriteLine("Ingrese la cantidad de habitantes");
            ciudad.CantHabitantes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la superficie en KM2");
            ciudad.Superficie = int.Parse(Console.ReadLine());
            return ciudad;
        }
        else
        {
            return null;
        }
    }
}
