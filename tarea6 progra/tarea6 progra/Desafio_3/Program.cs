class Program
{
    static void Main()
    {
        List<string> tareas = new List<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE TAREAS ===");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Eliminar");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nLista de tareas:");
                    if (tareas.Count == 0)
                        Console.WriteLine("No hay tareas.");
                    else
                    {
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine(i + ": " + tareas[i]);
                        }
                    }
                    break;

                case 2:
                    Console.Write("Nueva tarea: ");
                    tareas.Add(Console.ReadLine());
                    Console.WriteLine("Tarea agregada.");
                    break;

                case 3:
                    Console.Write("Índice a eliminar: ");
                    int index = int.Parse(Console.ReadLine());
                    if (index >= 0 && index < tareas.Count)
                    {
                        tareas.RemoveAt(index);
                        Console.WriteLine("Tarea eliminada.");
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (true); // se repite siempre
    }
}