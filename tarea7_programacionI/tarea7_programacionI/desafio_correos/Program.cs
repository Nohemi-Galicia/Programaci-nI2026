using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string texto = "Contactos: maria.lopez@gmail.com, carlos123@empresa.com. También puedes escribir a ana_perez@miempresa.org.";

        Console.WriteLine("Texto analizado:");
        Console.WriteLine(texto + "\n");

        string patron = @"[a-zA-Z0-9._-]+@[a-zA-Z.]+\.[a-zA-Z]+";

        MatchCollection correos = Regex.Matches(texto, patron);

        Console.WriteLine("Correos encontrados:\n");

        if (correos.Count > 0)
        {
            foreach (Match correo in correos)
            {
                Console.WriteLine(correo.Value.TrimEnd('.'));
            }
        }
        else
        {
            Console.WriteLine("No se encontraron correos.");
        }
    }
}