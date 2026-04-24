class Program
{
    static void Main()
    {
        double[,] compras = {
            {50, 120, 200, 80, 60},     // Cliente 1
            {300, 150, 100, 200, 50},   // Cliente 2
            {20, 30, 40, 10, 50},       // Cliente 3
            {500, 600, 200, 300, 100},  // Cliente 4
            {1000, 200, 150, 100, 50}   // Cliente 5
        };

        for (int i = 0; i < 5; i++)
        {
            double total = 0;

            for (int j = 0; j < 5; j++)
            {
                total += compras[i, j];
            }

            double descuento = 0;

            if (total >= 100 && total <= 1000)
                descuento = total * 0.10;
            else if (total > 1000)
                descuento = total * 0.20;

            Console.WriteLine("\nCliente " + (i + 1));
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total final: " + (total - descuento));
        }

        Console.ReadKey(); // para que no se cierre
    }
}