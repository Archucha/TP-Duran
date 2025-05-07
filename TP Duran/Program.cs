using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Duran;
internal class Program
{
    public List<Provincia> provincias = new();
    private static void Main(string[] args)
    {
        {
            
        }
    }
    public string CargarCiudad(Ciudad ciudad)
    {
        Console.WriteLine("Ingrese el nombre de la ciudad");
        ciudad.Nombre = Console.ReadLine();
        if (!string.IsNullOrEmpty(ciudad.Nombre))
        {

            return nuevaciudad;
        }
        else
        {
            return null;
        }
    }
}
