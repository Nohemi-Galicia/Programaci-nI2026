class Program
{
    static void Main()
    {
        char[,] tablero = {
            { '-', '-', '-' },
            { '-', '-', '-' },
            { '-', '-', '-' }
        };

        char jugador = 'X';

        for (int turno = 0; turno < 9; turno++)
        {
            Console.Clear();
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Jugador " + jugador);
            Console.Write("Fila: ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Columna: ");
            int col = int.Parse(Console.ReadLine());

            if (tablero[fila, col] == '-')
            {
                tablero[fila, col] = jugador;
                jugador = (jugador == 'X') ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("Posición ocupada");
                turno--;
                Console.ReadKey();
            }
        }
    }
}