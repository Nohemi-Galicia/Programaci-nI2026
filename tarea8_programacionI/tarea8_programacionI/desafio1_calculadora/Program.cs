class Program
{
    static void Main()
    {
        // CALCULADORA

        Calculadora c = new Calculadora();
        c.Marca = "Casio";
        c.Serie = "A1";

        Console.WriteLine("CALCULADORA");
        Console.WriteLine("Marca: " + c.Marca);
        Console.WriteLine("Serie: " + c.Serie);

        Console.WriteLine("Suma: " + c.Sumar(10, 5));
        Console.WriteLine("Resta: " + c.Restar(10, 5));
        Console.WriteLine("Multiplicación: " + c.Multiplicar(10, 5));
        Console.WriteLine("División: " + c.Dividir(10, 5));


        // CALCULADORA CIENTÍFICA

        CalculadoraCientifica cc = new CalculadoraCientifica();
        cc.Marca = "Texas";
        cc.Serie = "C99";

        Console.WriteLine("\nCALCULADORA CIENTÍFICA");
        Console.WriteLine("Marca: " + cc.Marca);
        Console.WriteLine("Serie: " + cc.Serie);

        Console.WriteLine("Potencia: " + cc.Potencia(2, 3));
        Console.WriteLine("Raíz: " + cc.Raiz(16));
        Console.WriteLine("Módulo: " + cc.Modulo(10, 3));
        Console.WriteLine("Logaritmo: " + cc.Logaritmo(10));
    }
}

class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public double Sumar(double a, double b) => a + b;
    public double Restar(double a, double b) => a - b;
    public double Multiplicar(double a, double b) => a * b;

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("No se puede dividir entre 0");
            return 0;
        }
        return a / b;
    }
}

class CalculadoraCientifica : Calculadora
{
    public double Potencia(double a, double b) => Math.Pow(a, b);
    public double Raiz(double a) => Math.Sqrt(a);
    public double Modulo(double a, double b) => a % b;
    public double Logaritmo(double a) => Math.Log(a);
}