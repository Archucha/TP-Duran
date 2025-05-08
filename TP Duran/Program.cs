using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Duran;
internal class Program
{
    public static List<Provincia> provincias = new();
    public static void Main(string[] args)
    {
        {
            Provincia p;
            do
            {
                p = CargarProvincia();
                if(p != null)
                {
                    provincias.Add(p);
                }
            }while(!string.IsNullOrEmpty(p.Nombre));
            Console.WriteLine("Provincias:");
            foreach (Provincia pr in provincias)
            {
                Console.WriteLine(pr.Nombre + pr.Gobernador + pr.Region);

                foreach (Ciudad ci in pr.ciudades)
                {
                    Console.WriteLine(ci.CantHabitantes + ci.Nombre + ci.Superficie);
                }
            }
            
            Console.ReadKey();
        }
    }
    public static Provincia CargarProvincia()
    {
        Provincia provincia = new Provincia();
        Console.WriteLine("Ingrese el nombre de la provincia");
        provincia.Nombre = Console.ReadLine();
        if (!string.IsNullOrEmpty(provincia.Nombre))
        {
            Console.WriteLine("Ingrese el nombre del gobernador");
            provincia.Gobernador = Console.ReadLine();
            Console.WriteLine("Ingrese la region");
            provincia.Region = Console.ReadLine();
            Ciudad c;
            do
            {
                c = CargarCiudad();
                if (c != null)
                {
                    provincia.ciudades.Add(c);
                }
            } while (!string.IsNullOrEmpty(c.Nombre));
            return provincia;
        }
        else
        {
            return null;
        }
    }
    public static Ciudad CargarCiudad()
    {
        Ciudad ciudad = new Ciudad();
        do
        {
            Console.WriteLine("Ingrese el nombre de la ciudad");
            ciudad.Nombre = Console.ReadLine();
            if (!string.IsNullOrEmpty(ciudad.Nombre))
            {
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
        } while (!string.IsNullOrEmpty(ciudad.Nombre));
    }
}
