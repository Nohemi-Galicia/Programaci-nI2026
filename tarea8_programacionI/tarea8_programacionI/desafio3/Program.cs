class Auto
{
    protected List<string> historial = new List<string>();

    public virtual void Reparar(string reparacion)
    {
        historial.Add(reparacion);
    }

    public virtual void HistoriaDeReparaciones()
    {
        Console.WriteLine("Historial:");
        foreach (var r in historial)
        {
            Console.WriteLine(r);
        }
    }
}

class BMW : Auto
{
    private string ruta;

    public BMW()
    {
        // Guarda en la raíz del proyecto (donde está Program.cs)
        ruta = Path.Combine(
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
            "reparaciones.txt"
        );
    }

    public override void Reparar(string reparacion)
    {
        File.AppendAllText(ruta, reparacion + Environment.NewLine);
        Console.WriteLine("Guardado en: " + ruta);
    }

    public override void HistoriaDeReparaciones()
    {
        if (File.Exists(ruta))
        {
            Console.WriteLine("\nHistorial desde archivo:");
            Console.WriteLine(File.ReadAllText(ruta));
        }
        else
        {
            Console.WriteLine("No hay reparaciones.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BMW bmw = new BMW();

        bmw.Reparar("Cambio de aceite");
        bmw.Reparar("Frenos");

        bmw.HistoriaDeReparaciones();
    }
}